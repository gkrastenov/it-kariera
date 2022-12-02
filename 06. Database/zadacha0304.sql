--Problem 1.
use SoftUni;
insert into towns (name) values
('Plovdiv'), ('Varna'), ('Burgas');

insert into departments (name, manager_id) values
('Engineering', 1), ('Sales', 1), ('Marketing', 1), ('Software Development', 1), ('Quality Assurance', 1);

--Problem 2.
use softuni;
select * from towns, departments, employees;

--Problem 3.
select name from towns;
select name from departments;
select first_name, last_name, job_title, salary from employees;

--Problem 4.
update employees
set salary = salary * 1.10;

--Problem 5.
use Hotel;
update payments
set tax_rate = tax_rate - tax_rate * 0.03;

--Problem 6.
truncate occupancies;
