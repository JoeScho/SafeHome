INSERT INTO PDC_Customer(Username, Password)
VALUES ('JoeScho','password'),
('Mims','password'),
('Jam','password'),
('Ryan','password');

INSERT INTO PDC_Room(RoomName, CustomerID)
VALUES ('Kitchen',1),
('Living Room',1),
('Bedroom',1),
('Kitchen',2),
('Living Room',2),
('Kitchen',3),
('Bedroom',3),
('Living Room',3),
('Bedroom',4),
('Kitchen',4);

INSERT INTO PDC_SensorType(SensorName)
VALUES ('Door / Window Contact'),
('Movement'),
('Fire'),
('Breaking Glass'),
('Vibration');

INSERT INTO PDC_Sensor(SensorTypeID, RoomID)
VALUES (1,1),
(2,1),
(1,2),
(3,3),
(4,3),
(5,4),
(3,6),
(4,7),
(2,8),
(4,9),
(5,10),
(4,5);