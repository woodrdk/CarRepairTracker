using CarRepairTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRepairTracker
{
    public partial class frmCarSelection : Form
    {
        byte[] rijnKey = Encoding.ASCII.GetBytes("abcdefg_abcdefg_abcdefg_abcdefg_");
        byte[] rijnIV = Encoding.ASCII.GetBytes("abcdefg_abcdefg_");

        // https://docs.microsoft.com/en-us/dotnet/standard/security/walkthrough-creating-a-cryptographic-application 
        // previous link is for tutorial the cryptogrophay here was referenced from.


        // Declare CspParmeters and RsaCryptoServiceProvider objects with global scope of your Form class.
        CspParameters cspp = new CspParameters();
        RSACryptoServiceProvider rsa;

        // Path variables for source, encryption, and decryption folders. Must end with a backslash.
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        const string SrcFolder = @"c:\docs\";

        // Public key file
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        // Key container name for private/public key value pair.
        const string keyName = "Key01";

        public frmCarSelection()
        {
            InitializeComponent();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmCarSelection_Load(object sender, EventArgs e)
        {
            DateTime currYear = DateTime.Now;
            int year = currYear.Year;
            for (int i = year + 1; i > 1900; i--)
            {
                cbYear.Items.Add(i);
            }

            cbMake.SelectedItem = "";
                // temp vars for testing
            cbTrim.Items.Add("HEMI");
            cbEngine.Items.Add("V8");
        }

        private void label9_Click(object sender, EventArgs e)
        {
        // believe can be deleted needs verified
        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            String make = cbMake.Text;
            String year = cbYear.Text;
            List<Model> Models = Model.GetAllModels(make, year);
            cbModel.DataSource = Models;
            cbModel.DisplayMember = nameof(Model.Name);
            // need to set this up to change models when this is refreshed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String year = cbYear.Text;
            List<Make> Makes = Make.GetAllMakes(year);
            cbMake.DataSource = Makes;
            cbMake.DisplayMember = nameof(Make.Name);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var ifCarAdded = UserCar.GetAllUserCars().Count();
            using (CarRepairDbContext objUserContext = new CarRepairDbContext())
            {
                UserCar userCars = new UserCar();

                userCars.UserId = IntroWho.whoUsing; //((FrmMain)MdiParent).whoIsUsing;
                    //IntroWho.cbWho_SelectedIndexChanged(sender, e); // pulls the variable of whos owner of car from intro form
                userCars.CarNameDescription = txtCarNameIdentifier.Text;
                userCars.Year = Int32.Parse( cbYear.SelectedItem.ToString());
                userCars.Make = ((Make)cbMake.SelectedItem).Name;
                    // another way to do prev line of code
                    // Make SelectedMake = cbMake.SelectedItem as Make;
                    // userCars.Make = SelectedMake.Name;
                userCars.Model = ((Model)cbModel.SelectedItem).Name;
                userCars.Trim = cbTrim.SelectedItem.ToString(); ;
                userCars.Engine = cbEngine.SelectedItem.ToString(); ;
                userCars.Vin = txtVin.Text;
                userCars.Plate = txtPlate.Text;
                userCars.State = txtState.Text;
                userCars.Color = txtColor.Text;
                userCars.UniqueIdentifiers = rtbUnique.Text;
                userCars.OilGrade = txtOilGrade.Text;
                userCars.OilFilter = txtOilFilter.Text;
                userCars.AirFilter = txtAirFilter.Text;
                userCars.SparkPlugs = txtSparkPlugs.Text;
                userCars.HeadlightBulb = txtHeadlight.Text;
                userCars.TireSize = txtTireSize.Text;
                userCars.PurchaseDate = datePurchase.Value; 
                //userCars.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text); //double.Parse
                //userCars.PurchaseMileage = Convert.ToInt32(txtPurchaseMileage.Text);
                //userCars.Warranty = Convert.ToBoolean( cbWarranty.Text); // need to get data
                userCars.ExpirationDate = dtpWarrExp.Value;
                //userCars.ExpirationMileage = Convert.ToInt32(txtWarrMileage.Text);
                userCars.Comments = txtComments.Text;
                userCars.Notes = rtbNotes.Text;
                objUserContext.UserCars.Add(userCars);
                objUserContext.SaveChanges();
           
                // code to verify car added needs work
                if((ifCarAdded + 1) == UserCar.GetAllUserCars().Count())
                {
                    Close();
                    MessageBox.Show("Car Successfully Added");
                }
            };
        }

        private void cbWarranty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWarranty.Checked)
            {
                cbWarranty.Text = "True";
            }
            else
            {
                cbWarranty.Text = "False";
            }
        }

        private void cbTrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
 
        
        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void SaveNotes()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = GetMyDocumentsPath();
            save.Filter = "Text File | *.txt:";
            // save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                if (path == string.Empty)
                {
                    return;
                }
                StringBuilder CarNotes = GetNotesFromRTB();
                File.WriteAllText(path, CarNotes.ToString());
                MessageBox.Show("Data was saved");
                rtbNotes.Text = "";
            }
        }

        private StringBuilder GetNotesFromRTB()
        {
            StringBuilder CarNotes = new StringBuilder();
            CarNotes.AppendLine(rtbNotes.Text);
            
            return CarNotes;
        }

        private string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnLoadNotes_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = GetMyDocumentsPath();

            fileDialog.Filter = "Text File |*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                // read the file
                List<string> noteDetails = File.ReadLines(fileDialog.FileName).ToList();
                rtbNotes.Text = "";
                foreach (string note in noteDetails)
                {
                    rtbNotes.Text += (note + Environment.NewLine);
                }

            }
        }


        /// encryption code
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // create key, Stores a key pair in the key container.
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
           
            // ---------------------------------------------
            // exports the publc key 

            // Save the public key created by the RSA to a file. Is a security risk.
            Directory.CreateDirectory(EncrFolder);
            StreamWriter sw = new StreamWriter(PubKeyFile, false);
            sw.Write(rsa.ToXmlString(false));
            sw.Close();

            // imports the key
            StreamReader sr = new StreamReader(PubKeyFile);
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            string keytxt = sr.ReadToEnd();
            rsa.FromXmlString(keytxt);
            rsa.PersistKeyInCsp = true;
                // prepare to delete following
                //if (rsa.PublicOnly == true)
                //    label1.Text = "Key: " + cspp.KeyContainerName + " - Public Only";
                //else
                //    label1.Text = "Key: " + cspp.KeyContainerName + " - Full Key Pair";
            sr.Close();

            //---------------------------------------------------------
            if (rsa == null)
                MessageBox.Show("Key not set.");
            else
            {

                // Display a dialog box to select a file to encrypt.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.InitialDirectory = SrcFolder;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog1.FileName;
                    if (fName != null)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        // Pass the file name without the path.
                        string name = fInfo.FullName;
                        EncryptFile(name);
                    }
                }
            }
        }

        private void EncryptFile(string inFile)
        {

            // Create instance of Rijndael for symetric encryption of the data.
            RijndaelManaged rjndl = new RijndaelManaged();
            rjndl.KeySize = 256;
            rjndl.BlockSize = 256;
            rjndl.Mode = CipherMode.CBC;
            ICryptoTransform transform = rjndl.CreateEncryptor();

            // Use RSACryptoServiceProvider to enrypt the Rijndael key.
            // rsa is previously instantiated: rsa = new RSACryptoServiceProvider(cspp);
            byte[] keyEncrypted = rsa.Encrypt(rjndl.Key, false);

            // Create byte arrays to contain the length values of the key and IV.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenK = BitConverter.GetBytes(lKey);
            int lIV = rjndl.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            // Write the following to the FileStream
            // for the encrypted file (outFs):
            // - length of the key
            // - length of the IV
            // - ecrypted key
            // - the IV
            // - the encrypted cipher content

            int startFileName = inFile.LastIndexOf("\\") + 1;
            // Change the file's extension to ".enc"
            string outFile = EncrFolder + inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";

            using (FileStream outFs = new FileStream(outFile, FileMode.Create))
            {

                outFs.Write(LenK, 0, 4);
                outFs.Write(LenIV, 0, 4);
                outFs.Write(keyEncrypted, 0, lKey);
                outFs.Write(rjndl.IV, 0, lIV);

                // Now write the cipher text using a CryptoStream for encrypting.
                using (CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {

                    // By encrypting a chunk at a time, you can save memory and accommodate large files.
                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = rjndl.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        }
                        while (count > 0);
                        inFs.Close();
                    }
                    outStreamEncrypted.FlushFinalBlock();
                    outStreamEncrypted.Close();
                }
                outFs.Close();
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {   // get private key
            cspp.KeyContainerName = keyName;

            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            if (rsa.PublicOnly == true)
                label1.Text = "Key: " + cspp.KeyContainerName + " - Public Only";
            else
                label1.Text = "Key: " + cspp.KeyContainerName + " - Full Key Pair";

            //----------------------

            if (rsa == null)
                MessageBox.Show("Key not set.");
            else
            {
                // Display a dialog box to select the encrypted file.
                OpenFileDialog openFileDialog2 = new OpenFileDialog();
                openFileDialog2.InitialDirectory = EncrFolder;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string fName = openFileDialog2.FileName;
                    if (fName != null)
                    {
                        FileInfo fi = new FileInfo(fName);
                        string name = fi.Name;
                        DecryptFile(name);
                    }
                }
            }
        }

        private void DecryptFile(string inFile)
        {

            // Create instance of Rijndael for symetric decryption of the data.
            RijndaelManaged rjndl = new RijndaelManaged();
            rjndl.KeySize = 256;
            rjndl.BlockSize = 256;
            rjndl.Mode = CipherMode.CBC;

            // Create byte arrays to get the length of the encrypted key and IV.
            // These values were stored as 4 bytes each at the beginning of the encrypted package.
            byte[] LenK = new byte[4];
            byte[] LenIV = new byte[4];

            // Consruct the file name for the decrypted file.
            string outFile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".txt";

            // Use FileStream objects to read the encrypted file (inFs) and save the decrypted file (outFs).
            using (FileStream inFs = new FileStream(EncrFolder + inFile, FileMode.Open))
            {

                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenK, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                // Convert the lengths to integer values.
                int lenK = BitConverter.ToInt32(LenK, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                // Determine the start postition of the ciphter text (startC) and its length(lenC).
                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                // Create the byte arrays for the encrypted Rijndael key, the IV, and the cipher text.
                byte[] KeyEncrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                // Extract the key and IV starting from index 8 after the length values.
                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Read(KeyEncrypted, 0, lenK);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);
                Directory.CreateDirectory(DecrFolder);
                // Use RSACryptoServiceProvider to decrypt the Rijndael key.
                byte[] KeyDecrypted = rsa.Decrypt(KeyEncrypted, false);

                // Decrypt the key.
                ICryptoTransform transform = rjndl.CreateDecryptor(KeyDecrypted, IV);

                // Decrypt the cipher text from from the FileSteam of the encrypted
                // file (inFs) into the FileStream for the decrypted file (outFs).
                using (FileStream outFs = new FileStream(outFile, FileMode.Create))
                {

                    int count = 0;
                    int offset = 0;

                    // blockSizeBytes can be any arbitrary size.
                    int blockSizeBytes = rjndl.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];


                    // By decrypting a chunk a time, you can save memory and accommodate large files.

                    // Start at the beginning of the cipher text.
                    inFs.Seek(startC, SeekOrigin.Begin);
                    using (CryptoStream outStreamDecrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);

                        }
                        while (count > 0);

                        outStreamDecrypted.FlushFinalBlock();
                        outStreamDecrypted.Close();
                    }
                    outFs.Close();
                }
                inFs.Close();
            }

        }

        private void btnEncNotes_Click(object sender, EventArgs e)
        {
               
            

            rtbNotes.Text = EncryptIt(rtbNotes.Text, rijnKey, rijnIV);
            
        }

        private String EncryptIt(String s, byte[] key, byte[] IV)
        {
            String result;
            RijndaelManaged rijn = new RijndaelManaged();
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (ICryptoTransform encryptor = rijn.CreateEncryptor(key, IV))
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(s);
                        }
                    }
                }
                result = System.Convert.ToBase64String(msEncrypt.ToArray());
            }
            rijn.Clear();
            return result;
        }

        private String DecryptIt(String s, byte[] key, byte[] IV)
        {
            String result;
            RijndaelManaged rijn = new RijndaelManaged();
            using (MemoryStream msDecrypt = new MemoryStream(System.Convert.FromBase64String(s)))
            {
                using (ICryptoTransform decryptor = rijn.CreateDecryptor(key, IV))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader swDecrypt = new StreamReader(csDecrypt))
                        {
                            result = swDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            rijn.Clear();
            return result;
        }

        private void btnDecNotes_Click(object sender, EventArgs e)
        {
            rtbNotes.Text = DecryptIt(rtbNotes.Text, rijnKey, rijnIV);
        }
    }

}
