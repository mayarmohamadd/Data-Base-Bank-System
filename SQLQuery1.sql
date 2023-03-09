CREATE TABLE bank
(
  name varchar(20) NOT NULL,
  code INT NOT NULL,
  address varchar(40) NOT NULL,
  PRIMARY KEY (code)
);

CREATE TABLE branches
(
  adress VARCHAR(250) NOT NULL,
  bnum INT NOT NULL,
  code INT NOT NULL,
  PRIMARY KEY (bnum),
  FOREIGN KEY (code) REFERENCES bank(code)
);

CREATE TABLE customer
(
  ssn INT NOT NULL,
  address VARCHAR(250) NOT NULL,
  name VARCHAR(50) NOT NULL,
  phone INT NOT NULL,
  PRIMARY KEY (ssn),
  bnum INT NOT NULL,
  FOREIGN KEY(bnum) REFERENCES branches(bnum)
);

CREATE TABLE loan
(
  loan_number INT NOT NULL,
  loan_type VARCHAR NOT NULL,
  loan_amount VARCHAR NOT NULL,
  PRIMARY KEY (loan_number)
);
ALTER TABLE loan
DROP COLUMN loan_amount;
ALTER TABLE loan
ADD loan_amount INT;

ALTER TABLE loan
DROP COLUMN loan_type;
ALTER TABLE loan
ADD loan_type VARCHAR(20);


CREATE TABLE accounts
(
  type VARCHAR NOT NULL,
  balance INT NOT NULL,
  account_number INT NOT NULL,
  PRIMARY KEY (account_number)
);

CREATE TABLE borrower
(
  loan_number INT NOT NULL,
  ssn INT NOT NULL,
  PRIMARY KEY (loan_number, ssn),
  FOREIGN KEY (loan_number) REFERENCES loan(loan_number),
  FOREIGN KEY (ssn) REFERENCES customer(ssn)
);

CREATE TABLE hold_by
(
  ssn INT NOT NULL,
  account_number INT NOT NULL,
  PRIMARY KEY (ssn, account_number),
  FOREIGN KEY (ssn) REFERENCES customer(ssn),
  FOREIGN KEY (account_number) REFERENCES accounts(account_number)
);



CREATE TABLE offer
(
  bnum INT NOT NULL,
  loan_number INT NOT NULL,
  PRIMARY KEY (bnum, loan_number),
  FOREIGN KEY (bnum) REFERENCES branches(bnum),
  FOREIGN KEY (loan_number) REFERENCES loan(loan_number)
);

CREATE TABLE employee
(
  id INT NOT NULL,
  ename VARCHAR(250) NOT NULL,
  salary FLOAT NOT NULL,
  bnum INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (bnum) REFERENCES branches(bnum)
);

CREATE TABLE admin
(
  id INT NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (id) REFERENCES employee(id)
);

CREATE TABLE cust_banker
(
  id INT NOT NULL,
  ssn INT NOT NULL,
  PRIMARY KEY (id, ssn),
  FOREIGN KEY (id) REFERENCES employee(id),
  FOREIGN KEY (ssn) REFERENCES customer(ssn)
);

CREATE TABLE add_loan
(
  loan_number INT NOT NULL,
  id INT NOT NULL,
  PRIMARY KEY (loan_number, id),
  FOREIGN KEY (loan_number) REFERENCES loan(loan_number),
  FOREIGN KEY (id) REFERENCES employee(id)
);


insert into branches values( 'cairo' ,'1','001')
insert into branches values( 'giza' ,'2','001')
insert into branches values( 'alex' ,'3','001')


insert into customer values ('1','gize','ali','01122334','1')
insert into customer values ('2','cairo','mohammed','011556334','2')
insert into customer values ('3','alex','ahmed','011556334','2')

insert into bank values('bank1','001','cairo')

insert into employee values ('1','ahmed','1000','1')
insert into employee values ('2','mohammed,]','2000','2')

insert into loan(loan_number,loan_type,loan_amount) values ('1','Debt','1000')
insert into loan(loan_number,loan_type,loan_amount) values ('2','Debt','2000')
insert into loan(loan_number,loan_type,loan_amount) values ('3','Debt','2000')
insert into loan(loan_number,loan_type,loan_amount) values ('4','Debt','5000')


insert into add_loan values ('1','1')
insert into add_loan values ('2','1')
insert into add_loan values ('3','2')
insert into add_loan values ('4','1')

insert into borrower values ('1','1')
insert into borrower values ('2','2')
insert into borrower values ('3','1')
insert into borrower values ('4','1')

insert into cust_banker values ('1','1')
insert into cust_banker values ('2','2')
insert into cust_banker values ('2','3')

select bnum
from branches
where bnum not in (select bnum
	from customer
);


select *
from branches
where bnum not in (select bnum
	from employee
);


select TOP 1 PERCENT e.ename, count(*) as counts
from employee as e
join add_loan
on add_loan.id=e.id
group by ename
order by counts desc
;

select TOP 1 PERCENT c.name, count(*) as counts
from customer as c
join borrower
on borrower.ssn=c.ssn
group by name
order by counts desc
;


SELECT c.ssn,c.name
FROM customer c
LEFT JOIN borrower t ON t.ssn = c.ssn
LEFT JOIN loan l ON l.loan_number = t.loan_number
WHERE l.loan_number   IS NULL



SELECT cu.ssn,cu.address,cu.name,cu.phone,cu.bnum,cb.id
from customer as cu
INNER JOIN cust_banker as cb
ON cu.ssn=cb.ssn



CREATE TABLE admin_signup
(
  name varchar(20) NOT NULL,
  pass INT NOT NULL
);
CREATE TABLE emp_signup
(
  name varchar(20) NOT NULL,
  pass INT NOT NULL
);

CREATE TABLE cust_signup
(
  name varchar(20) NOT NULL,
  pass INT NOT NULL
);

 





