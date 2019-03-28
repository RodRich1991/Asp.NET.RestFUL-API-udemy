CREATE TABLE persons (
	Id INT(10) NOT NULL AUTO_INCREMENT,
    FirstName varchar(50) null default null,
    LastName varchar(50) null default null,
    Address varchar(50) null default null,
    Gender varchar(50) null default null,
	PRIMARY KEY (Id)
) ENGINE = InnoDB;