CREATE TABLE PDC_Customer (
  CustomerID Int IDENTITY (1,1) NOT NULL PRIMARY KEY,
  Username Varchar(255) NOT NULL,
  Password Varchar(255) NOT NULL
);

CREATE TABLE PDC_Room (
  RoomID Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
  RoomName Varchar(255) NOT NULL,
  CustomerID Int NOT NULL FOREIGN KEY REFERENCES PDC_Customer(CustomerID),
  FloorNumber Int,
  RoomIDNorth Int FOREIGN KEY REFERENCES PDC_Room(RoomID),
  DoorNorth BIT,
  RoomIDEast Int FOREIGN KEY REFERENCES PDC_Room(RoomID),
  DoorEast BIT,
  RoomIDSouth Int FOREIGN KEY REFERENCES PDC_Room(RoomID),
  DoorSouth BIT,
  RoomIDWest Int FOREIGN KEY REFERENCES PDC_Room(RoomID),
  DoorWest BIT
);

CREATE TABLE PDC_SensorType (
  SensorTypeID Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
  SensorName Varchar(255) NOT NULL
);

CREATE TABLE PDC_Sensor (
  SensorID Int NOT NULL IDENTITY (1,1) PRIMARY KEY,
  SensorTypeID Int NOT NULL FOREIGN KEY REFERENCES PDC_SensorType(SensorTypeID),
  RoomID Int NOT NULL FOREIGN KEY REFERENCES PDC_Room(RoomID)
);