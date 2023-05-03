CREATE TABLE WatchHistory
(
    Id_fw INT REFERENCES FactoryWorker (Id_fw),
    ArrivalTime smalldatetime, 
    CareTime smalldatetime 
);