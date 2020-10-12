UPDATE dbo.FeladatTabla 
   SET Kep = (SELECT BulkColumn
   FROM OPENROWSET(BULK N'C:\Users\black\OneDrive - Corvinus University of Budapest\Egészségügyi ismeretek\érettségi feladatsorok\2019\május\19m1.jpg', SINGLE_BLOB))
   WHERE Ev = 2019 and Honap = 'október' and FeladatSorszama = 1;
