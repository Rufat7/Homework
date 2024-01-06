	CREATE TABLE Users (
    [user_id] INT PRIMARY KEY identity (1, 1),
    username nvarchar(max),
    [password] nvarchar(max),
    email nvarchar(max)
);

CREATE TABLE ManufacturingCountries (
    country_id INT PRIMARY KEY identity (1, 1),
    country_name nvarchar(max) NOT NULL UNIQUE
);

CREATE TABLE FuelTypes (
    fuel_type_id INT PRIMARY KEY identity (1, 1),
    fuel_type nvarchar(max) NOT NULL UNIQUE
);

CREATE TABLE BodyTypes (
    body_type_id INT PRIMARY KEY identity (1, 1),
    body_type nvarchar(max) NOT NULL UNIQUE
);

CREATE TABLE Colors (
    color_id INT PRIMARY KEY identity (1, 1),
    color_name nvarchar(max) NOT NULL UNIQUE
);

CREATE TABLE Cars (
    car_id INT PRIMARY KEY identity (1, 1),
    brand nvarchar(max),
    model nvarchar(max),
    [year] int check ([year] <= 2024),
    image_link VARCHAR(max),
    fuel_type_id int foreign key references FuelTypes(fuel_type_id),
    body_type_id int foreign key references BodyTypes(body_type_id),
    color_id int foreign key references Colors(color_id)
);

CREATE TABLE Sellers (
    seller_id INT PRIMARY KEY identity (1, 1),
	company_name nvarchar(max),
    contact_number nvarchar(60) NOT NULL UNIQUE,
    rating INT,
    [user_id] int foreign key references Users([user_id]),
    country_id int foreign key references ManufacturingCountries(country_id)
);

CREATE TABLE ProductList (
    product_id INT PRIMARY KEY identity (1, 1),
    price INT,
    quantity INT NOT NULL check (quantity >= 0),
    car_id int foreign key references Cars(car_id),
    seller_id int foreign key references Users([user_id])
);