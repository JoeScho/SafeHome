SELECT c.Username, s.RoomID, r.RoomName, st.SensorName
FROM PDC_Sensor AS s 
INNER JOIN PDC_SensorType AS st 
ON s.SensorTypeID = st.SensorTypeID 
INNER JOIN PDC_Room AS r 
ON r.RoomID = s.RoomID 
INNER JOIN PDC_Customer AS c 
ON c.CustomerID = r.CustomerID
WHERE c.CustomerID = 1
ORDER BY s.RoomID