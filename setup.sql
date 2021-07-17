CREATE TABLE Blogs(
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP  ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(255),
    string VARCHAR(255),
    imgUrl VARCHAR(255),
    published TINYINT NOT NULL,
    creatorId VARCHAR(255),
    FOREIGN KEY (creatorId)
    REFERENCES Profiles(id)
    ON DELETE CASCADE
    
) default charset utf8 comment '';
 
CREATE TABLE Profiles(
     createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
  id VARCHAR(255) PRIMARY KEY ,
   email VARCHAR(255),
   name VARCHAR (255),
   picture VARCHAR(255)
) default charset utf8 comment '';

-- INSERT INTO Profiles(id, Name, Email, Picture)
--             VALUES ("1", "name", "Email", "Picture");

-- SELECT * FROM Profiles;

-- CREATE TABLE Blogs(
--     createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'create time',
--     updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP  ON UPDATE CURRENT_TIMESTAMP COMMENT 'update time',
-- id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
--     title VARCHAR(255),
--     string VARCHAR(255),
--     imgUrl VARCHAR(255),
--     published TINYINT NOT NULL,
--     creatorId VARCHAR(255),
--     profiles_id VARCHAR(255) NOT NULL REFERENCES profiles(id)
-- ) default charset utf8 comment '';

-- ALTER TABLE Profiles MODIFY COLUMN id VARCHAR(255) PRIMARY KEY;
    


-- DROP TABLE Profiles;


-- ALTER TABLE Blogs  ADD CONSTRAINT fk_profiles_Id FOREIGN KEY(profiles_id)
-- REFERENCES Profiles(id);

