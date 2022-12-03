create table subjects
(
subject_id int primary key,
subject_name varchar(50)
);
create table majors
(
major_id int primary key,
name varchar(50)
);
create table students
(
student_id int primary key,
student_number varchar(12),
student_name varchar(50),
major_id int,
constraint fk_major_id foreign key (major_id) references majors(major_id)
);
create table payments
(
payment_id int,
payment_date date,
payment_amount decimal(8,2),
student_id int,
constraint fk_student_id foreign key (student_id) references students(student_id)
);
create table agenda
(
student_id int,
subject_id int,
constraint pk_student_subject primary key (student_id, subject_id),
constraint fk_student1_id foreign key (student_id) references students(student_id),
constraint fk_subject_id foreign key (subject_id) references subjects(subject_id)
);