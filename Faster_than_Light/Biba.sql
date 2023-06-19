CREATE TABLE "Client" (
 	"ClientID" serial PRIMARY KEY,
    "Name" character varying(50)  ,
    "Surname" character varying(50)  ,
    "Patronymic" character varying(50),
    "Birthdate" date  ,
    "SeriaNumberPassport" character(10)   UNIQUE,
    "PhoneNumber" character varying(11)  ,
    "Email" character varying(100)   UNIQUE
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
    "Post" character varying(200)
    "Login" character varying(20));

CREATE TABLE "DriverIdentification"(
	"GuideReferencesID" serial PRIMARY KEY,
    "DriverLicense" character(10)   UNIQUE,
    "B" BOOLEAN,
	"BE" BOOLEAN,
	"C" BOOLEAN,
	"CE" BOOLEAN,
    "DateReceipt" date  ,
    "TerminationDate" date,
	"EmployeeID" INTEGER,
	
	FOREIGN KEY ("EmployeeID") REFERENCES "Employee" ("EmployeeID") ON DELETE CASCADE 
);



CREATE TABLE "Warehouse"(
    "WarehouseID" serial PRIMARY KEY,
    "Address" character varying(200)  ,
    "Region" character varying(200)  ,
    "Director" integer,
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID") ON DELETE CASCADE
);

CREATE TABLE "PointReception"(
	"PointID" serial PRIMARY KEY,
    "Address" character varying(200)  ,
    "Director" integer  ,
    "WarehouseID" integer  ,
	
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID") ON DELETE CASCADE,
	FOREIGN KEY ("WarehouseID") REFERENCES "Warehouse" ("WarehouseID") ON DELETE CASCADE
);

CREATE TABLE "CargoСategory"(
	"CategoryID" serial PRIMARY KEY,
    "Name" character varying(200)  ,
    "TransportationCoefficient" numeric(10, 2)  ,
    "Comments" character varying(500)
);


CREATE TABLE "LocationBase"(
	"LocationBaseID" serial PRIMARY KEY,
    "Address" character varying(200),
    "NumberSeats" integer,
    "Region" character varying(200),
    "Director" integer,
	FOREIGN KEY ("Director") REFERENCES "Employee" ("EmployeeID") ON DELETE CASCADE
);

CREATE TABLE "Car"(
	"CarID" serial PRIMARY KEY,
    "VIN" character varying(17)   UNIQUE,
    "StateNumber" character varying(9)  ,
    "Stamp" character varying(200)  ,
    "Model" character varying(200)  ,
    "Mileage" integer  ,
    "NextMaintenance" integer  ,
    "Status" text  ,
    "LocationBase" integer  ,
    "DriverID" integer,
	
	FOREIGN KEY ("LocationBase") REFERENCES "LocationBase" ("LocationBaseID") ON DELETE CASCADE,
	FOREIGN KEY ("DriverID") REFERENCES "Employee" ("EmployeeID") ON DELETE SET NULL
);

CREATE TABLE "Package"(
	"PackageID" serial PRIMARY KEY,
    "ClientID" integer  ,
    "Comments" character varying(500),
    "SendingAddress" integer  ,
    "DeliveryAddress" integer  ,
    "Weight" numeric(10, 2)  ,
    "DateAcceptance" timestamp without time zone  ,
    "DateDeliveryToPoint" timestamp without time zone  ,
    "DateIssue" timestamp without time zone  ,
    "EmployeeID" integer  ,
    "Length" integer,
	"Width" integer,
	"Height" integer,
    "PackageType" text  ,
    "DeliveryCost" numeric(10, 2)  ,
    "CargoCategory" integer  ,
    "Status" text  ,
    "CarID" integer,
	FOREIGN KEY ("ClientID") REFERENCES "Client" ("ClientID") ON DELETE CASCADE,
	FOREIGN KEY ("SendingAddress") REFERENCES "PointReception" ("PointID") ON DELETE CASCADE,
	FOREIGN KEY ("DeliveryAddress") REFERENCES "PointReception" ("PointID") ON DELETE CASCADE,
	FOREIGN KEY ("EmployeeID") REFERENCES "Employee" ("EmployeeID") ON DELETE CASCADE,
	FOREIGN KEY ("CargoCategory") REFERENCES "CargoСategory" ("CategoryID") ON DELETE CASCADE,
	FOREIGN KEY ("CarID") REFERENCES "Car" ("CarID") ON DELETE CASCADE
);
