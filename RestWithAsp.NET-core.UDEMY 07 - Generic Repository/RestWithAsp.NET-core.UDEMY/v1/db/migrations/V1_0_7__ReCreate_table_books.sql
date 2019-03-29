CREATE TABLE books (
	Id INT(10) NOT NULL AUTO_INCREMENT,
    Author longtext,
    LaunchDate datetime(6) not null,
    Price decimal(65,2) not null,
    Title longtext,
	PRIMARY KEY (Id)
) ENGINE = InnoDB;