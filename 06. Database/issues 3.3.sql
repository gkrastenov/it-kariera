-- IN THIS PART WE USE soft_uni_database from folder nubmer 01.

-- Task 2.
SELECT * FROM departments;

-- Task 3. 
SELECT name FROM departments;

-- Task 4. 
SELECT first_name, last_name, salary 
FROM employees;

-- Task 5.
SELECT first_name, middle_name, last_name
FROM employees;

-- Task 6. 
select first_name, middle_name, last_name from employees;

-- Taks 7
SELECT concat(`first_name`,'.',`last_name`,'@softuni.bg') AS 'full_email_address' 
FROM `employees`;

-- Task 8
select distinct `salary` from employees
order by salary ASC;

-- Task 9
select *
from employees
where `job_title` = "Sales Representative";

-- Task 10
SELECT concat(`first_name`,' ',`middle_name`, ' ',`last_name`) AS 'Full Name'
FROM `employees`
where `salary` = 25000 && 14000 && 12500 && 23600;

-- Task 11
select first_name, last_name 
from employees 
where `manager_id` is null;

-- Task 12
select first_name, last_name , salary
from employees
where salary > 50000;

-- Task 13
select first_name, last_name 
from employees 
order by salary desc limit 5;

-- Task 14
select first_name, last_name from employees where not department_id = 4;

-- Task 15
select distinct job_title from employees;

-- Task 16
select * from projects order by start_date asc limit 10;

-- Task 17
select first_name, last_name from employees order by hire_date desc limit 7;

-- Task 18
UPDATE employees
SET salary = salary + salary * 0.12
WHERE department_id IN (1, 2, 4, 5, 11);
SELECT salary FROM employees



-- IN THIS PART WE USE geography_database from folder nubmer 01.

-- Task 22. 
SELECT peak_name 
FROM peaks
ORDER BY peak_name;

-- Task 23. 
select country_name, population 
from countries 
where continent_code = 'EU' 
order by 
population desc,
country_name asc
limit 30

-- Task 24. The task is not solved  
select country_name ,
 country_code , 
 currency_code
 from countries 
 where currency_code = ( case when currency_code = 'EUR' then currency_code else 'Not Euro' END)

-- IN THIS PART WE USE diablo_database from folder nubmer 01.

-- Task 25.
SELECT name
FROM characters
ORDER BY name;
