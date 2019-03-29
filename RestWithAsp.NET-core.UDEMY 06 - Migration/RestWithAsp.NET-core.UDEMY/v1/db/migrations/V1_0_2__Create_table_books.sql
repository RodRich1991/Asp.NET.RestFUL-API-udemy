CREATE TABLE books (
	Id varchar(127) NOT NULL,
    Author longtext,
    LauchDate datetime(6) not null,
    Price decimal(65,2) not null,
    Title longtext,
	PRIMARY KEY (Id)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;