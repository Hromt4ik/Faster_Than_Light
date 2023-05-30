CREATE TABLE "Client" (
 	"ClientID" serial PRIMARY KEY,
    "Name" character varying(50) NOT NULL,
    "Surname" character varying(50) NOT NULL,
    "Patronymic" character varying(50),
    "Birthdate" date NOT NULL,
    "SeriaNumberPassport" character(10) NOT NULL UNIQUE,
    "PhoneNumber" character varying(11) NOT NULL,
    "Email" character varying(100) NOT NULL UNIQUE
);

CREATE TABLE "Employee"(
	"EmployeeID" serial PRIMARY KEY,
    "Password" text,
    "Name" character varying(50),
    "Surname" character varying(50),
    "Patronymic" character varying(50),
    "Birthdate" date,
    "SeriaNumberPassport" character varying(10) UNIQUE,
    "PhoneNumber" character varying(11),
    "ResidentialAddress" character varying(200),
    "Email" character varying(100) UNIQUE,
    "Post" character varying(200),
    "GuideReferencesID" integer
	
	
);

CREATE TABLE "DriverIdentification"(
	"GuideReferencesID" serial PRIMARY KEY,
    "DriverLicense" character(10) NOT NULL UNIQUE,
    "Category" json NOT NULL,
    "DateReceipt" date NOT NULL,
    "TerminationDate" date,
	"EmployeeID" INTEGER,
	
	FOREIGN KEY ("EmployeeID") REFERENCES "Employee" ("EmployeeID")
);



CREATE TABLE "Warehouse"(
    "WarehouseID" serial PRIMARY KEY,
    "Address" character varying(200) NOT NULL,
    "Region" character varying(200) NOT NULL,
    "Director" integer,
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID")
);

CREATE TABLE "PointReception"(
	"PointID" serial PRIMARY KEY,
    "Address" character varying(200) NOT NULL,
    "Director" integer NOT NULL,
    "WarehouseID" integer NOT NULL,
	
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID"),
	FOREIGN KEY ("WarehouseID") REFERENCES "Warehouse" ("WarehouseID")
);

CREATE TABLE "CargoСategory"(
	"CategoryID" serial PRIMARY KEY,
    "Name" character varying(200) NOT NULL,
    "TransportationCoefficient" numeric(10, 2) NOT NULL,
    "Comments" character varying(500)
);


CREATE TABLE "LocationBase"(
	"LocationBaseID" serial PRIMARY KEY,
    "Address" character varying(200),
    "NumberSeats" integer,
    "Region" character varying(200),
    "Director" integer,
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID")
);

CREATE TABLE "Car"(
	"CarID" serial PRIMARY KEY,
    "VIN" character varying(17) NOT NULL UNIQUE,
    "StateNumber" character varying(9) NOT NULL,
    "Stamp" character varying(200) NOT NULL,
    "Model" character varying(200) NOT NULL,
    "Mileage" integer NOT NULL,
    "NextMaintenance" integer NOT NULL,
    "Status" text NOT NULL,
    "LocationBase" integer NOT NULL,
    "DriverID" integer,
	
	FOREIGN KEY ("LocationBase") REFERENCES "LocationBase" ("LocationBaseID"),
	FOREIGN KEY ("DriverID") REFERENCES "Employee" ("EmployeeID")
);

CREATE TABLE "Package"(
	"PackageID" serial PRIMARY KEY,
    "ClientID" integer NOT NULL,
    "Comments" character varying(500),
    "SendingAddress" integer NOT NULL,
    "DeliveryAddress" integer NOT NULL,
    "Weight" numeric(10, 2) NOT NULL,
    "DateAcceptance" timestamp without time zone NOT NULL,
    "DateDeliveryToPoint" timestamp without time zone NOT NULL,
    "DateIssue" timestamp without time zone NOT NULL,
    "EmployeeID" integer NOT NULL,
    "Dimensions" json NOT NULL,
    "PackageType" text NOT NULL,
    "DeliveryCost" numeric(10, 2) NOT NULL,
    "CargoCategory" integer NOT NULL,
    "Status" text NOT NULL,
    "CarID" integer,
	FOREIGN KEY ("ClientID") REFERENCES "Client" ("ClientID"),
	FOREIGN KEY ("SendingAddress") REFERENCES "PointReception" ("PointID"),
	FOREIGN KEY ("DeliveryAddress") REFERENCES "PointReception" ("PointID"),
	FOREIGN KEY ("EmployeeID") REFERENCES "Employee" ("EmployeeID"),
	FOREIGN KEY ("CargoCategory") REFERENCES "CargoСategory" ("CategoryID"),
	FOREIGN KEY ("CarID") REFERENCES "Car" ("CarID")
);





