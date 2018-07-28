-- all auto brand year info is from wikipedia.com
INSERT Makes (BrandName, YearStarted, YearEnded) VALUES 
-- American Cars
( 'Dodge', 1900, 2018),
('AM General', 2011, null),
('Anteros', 2005, null),
('Aurica', 2010, null),
('Buick', 1903, null),
('BXR', 2008, null),
('Chrysler', 1925, null),
('Chevrolet', 1911, null),
('Cadillac', 1902, null),
('Dodge', 1900, null),
('Elio Motors', 2009, null),
('Equus Automotive', 2014, null),
('E-Z-GO', 1954, null),
('Falcon', 2009, null),
('Faraday', 2014, null),
('Fisker', 2011, 2014),
('Ford', 1903, null),
('GMC', 1913, null),
('Hennessey', 1991, null),
('Jeep', 1941, null),
('Karma', 2016, null),
('Lincoln', 1917, null),
('Local', 2007, null),
('Lucid Motors', 2014, null),
('Lyons', 2011, null),
('Mosler', 1993, 2013),
('Niama-Reisser', 2005, null),
('Panoz', 1989, null),
('Polaris', 1954, null),
('Pontiac', 1926, 2010),
('Racefab', 1991, null),
('Ram', 2009, null),
('Rezvani', 2014, null),
('Rossion', 2007, null),
('Shelby American', 1992, null),
('SSC', 1999, null),
('Tesla', 2003, null),
('Zimmer', 1978, 1988),
('Zimmer', 1997, null),

--Japanese
('Acura', 1986, null),
('Datsun', 1933, 1986),
('Honda', 1946, null),
('Infiniti', 1989, null),
('Isuzu', 1953, null),
('Lexus', 1989, null),
('Mazda', 1960, null),
('Mitsubishi', 1917, 1921),
('Mitsubishi', 1959, null),
('Nissan', 1933, null),
('Scion',  2003, 2016),
('Suzuki', 1956, null),
('Toyota', 1937, null),
('Subaru', 1953, null),

-- German
('Audi', 1989, null), 
('BMW', 1917, null),
('Mercedes-Benz', 1870, null),
('Opel', 1862, null), 
('Porsche', 1931, null), 
('Volkswagen', 1937, null) 




INSERT Models(ModelName, ModelYearStart, ModelYearEnd) VALUES 

('Magnum', 2005, 2008),
-- every Dodge made in 2000 below
('Avenger', 1995, 2000),
('Avenger', 2007, 2014),
('Caravan Passenger', 1984, null),
('Dakota', 1987, 2011),
('Durango', 1998, null),
('Intrepid', 1993, 2004),
('Neon', 1995, 2005),
('Ram', 1981, null),
('Ram Van', 1971, 2003),
('Stratus', 1995, 2006),
('Viper', 1991, 2017),

-- every Honda made in 2000 below
('Accord', 1976, null),
('Civic', 1972, null),
('CR-V', 1995, null),
('Insight', 1999, 2006),
('Insight', 2009, 2014),
('Insight', 2019, null),
('Odyssey', 1995, null),
('Passport', 1994, 2002),
('Prelude',  1978, 2001),
('S2000', 1999, 2008)

