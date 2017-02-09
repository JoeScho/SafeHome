-- Kitchen is north of Living Room (Customer 1)
UPDATE PDC_Room
SET RoomIDNorth=2, DoorNorth=1
WHERE RoomID=1;
UPDATE PDC_Room
SET RoomIDSouth=1, DoorSouth=1
WHERE RoomID=2;

-- Bedroom is east of Kitchen (Customer 1)
UPDATE PDC_Room
SET RoomIDEast=3, DoorEast=1
WHERE RoomID=1;
UPDATE PDC_Room
SET RoomIDWest=1, DoorWest=1
WHERE RoomID=3;