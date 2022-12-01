CREATE TABLE cities(
city_id int(11) PRIMARY KEY,
name varchar(50) default 'Plovdiv'
);

CREATE TABLE customers (	
customer_id int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
name varchar(50) NOT NULL,
birthday DATE check(birthday > 1990) ,
city_id int(11),
constraint FK_customers_cities
foreign key (city_id)
references cities(city_id)
);


CREATE TABLE orders(
order_id int(11) PRIMARY KEY,
customer_id int(11),
constraint FK_customer_orders
foreign key (customer_id)
references customers(customer_id)
);

CREATE TABLE item_types(
item_type_id int(11) PRIMARY KEY,
name varchar(50));

CREATE TABLE items(
item_id int(11) PRIMARY KEY,
name varchar(50),
item_type_id int(11),
constraint FK_items_itemTypes
foreign key (item_type_id)
references item_types(item_type_id)
);



-- CREATE TABLE order_items(
-- order_id int(11),
-- item_id int(11),
-- constraint FK_orderItems_order
-- foreign key (order_id)
-- references orders(order_id),
-- constraint FK_orderItems_items
-- foreign key (item_id)
-- references	items(item_id)
-- );





-- CREATE TABLE majors(
-- major_id int(11) PRIMARY KEY,
-- name varchar(50)
-- );

-- CREATE TABLE students(
-- student_id int(11) auto_increment PRIMARY KEY,
-- student_number varchar(12),
-- studen_name varchar(50),
-- major_id int(11),
-- constraint FK_students_majors
-- foreign key (major_id)
-- references majors (major_id)
-- );


-- CREATE TABLE payments(
-- payment_id int(11),
-- payment_date DATE,
-- payment_amount DECIMAL(8,2),
-- student_id int(11),
-- constraint FK_students_payments
-- foreign key (student_id)
-- references students(student_id)
-- );

-- CREATE TABLE subjects(
-- subject_id int(11)PRIMARY KEY,
-- subject_name varchar(50)
-- );

-- CREATE TABLE adenga(
-- student_id int(11),
-- subject_id int(11),
-- constraint FK_agenda_subject
-- foreign key (subject_id)
-- references subjects(subject_id),
-- constraint FK_agenda_students
-- foreign key (student_id)
-- references students(student_id)
-- );


