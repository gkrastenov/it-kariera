-- task 1
CREATE TABLE passports(
passport_id int PRIMARY KEY,
passport_number varchar(10)
);

CREATE TABLE persons(
person_id int AUTO_INCREMENT PRIMARY KEY,
first_name varchar(50) NOT NULL,
salary decimal(6,2),
passport_id int
);

ALTER TABLE persons
ADD CONSTRAINT FK_Persons_Passports 
FOREIGN KEY persons(passport_id) 
REFERENCES passports(passport_id)

 
CREATE TABLE IF NOT EXISTS manifactures(
manufacturer_id int PRIMARY KEY auto_increment,
name varchar(30),
established_on date
);

CREATE TABLE models(
model_id int PRIMARY KEY,
name varchar(30),
manufacturer_id
 int,
CONSTRAINT FK_manifactures_models
foreign key (manufacturer_id)
references manifactures(manufacturer_id)
);

-- task 2

CREATE TABLE IF NOT EXISTS students (
	student_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30)
);

CREATE TABLE IF NOT EXISTS exams (
	exam_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(30)
);

CREATE TABLE IF NOT EXISTS student_exams (
	student_id INT,
    exam_id INT,
    
constraint pk_student_exam
primary key(student_id, exam_id),

constraint fk_studentExams_students
foreign key(student_id)
references students(student_id),

CONSTRAINT fk_studentExams_exams 
FOREIGN KEY(exam_id)
REFERENCES exams(exam_id)
);

DROP TABLE student_exams; 
DROP TABLE students;
DROP TABLE exams;


CREATE TABLE teachers(
teacher_id int primary key,
name varchar(50),	
manager_id int);

ALTER TABLE teachers
  ADD FOREIGN KEY (manager_id) REFERENCES teachers (teacher_id)