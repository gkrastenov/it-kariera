create table item_types
(
item_type_id int primary key,
name varchar(50)
);
create table items
(
item_id int primary key,
name varchar(50),
item_type_id int,
constraint fk_item_type_id foreign key (item_type_id) references item_types(item_type_id)
);
create table cities
(
city_id int primary key,
name varchar(50) default 'Plovdiv'
);
create table customers
(
customer_id int primary key,
name varchar(50),
birthday date,
city_id int,
constraint fk_city_id foreign key (city_id) references cities(city_id)
);
create table orders
(
order_id int primary key,
customer_id int,
constraint fk_customer_id foreign key (customer_id) references customers(customer_id)
);
create table order_items
(
order_id int,
item_id int,
constraint pk_order_item primary key (order_id, item_id),
constraint fk_order_id foreign key (order_id) references orders(order_id),
constraint fk_item_id foreign key (item_id) references items(item_id)
);