Documentation of the project 

General Description of the project
The project is an attendance management system that allows the admin to make full CRUD operations on the users and the courses and the classes of the courses.
The project also allows the teacher to view the courses he teaches and the classes of the courses and the attendance of the students in each class of the course he teaches.

The project connects between 3 memper and 4 data files.

# Mempers 
1- Admin
2- Teacher
3- Student

# Data Files
1- Users.xml
2- Courses.xml
3- Attendance.xml
4- Configurations.xml

each member has his own data and own interface.

# Admin Interface
The admin interface is a dashboard that allows the admin to control the entire system.
adding, deleting , updating , and reading of the data of the users, courses' classes.


# Teacher Interface
The teacher interface allows the teacher to control his own personal data and view all the courses he teach and all the dates of all his courses.
The teacher can also view the attendance of the students in each class of the course he teaches at specific date.
and can generate reports for the attendance of the students in each subject he teaches.

# Student Interface
The student interface allows the student to view his own personal data 
and generate reports for the attendance of the students in each subject he attends.

# Data Files

1- Users.xml
the file contains the data of all the users in the system.
each user has his own role and his own data: 
- id
- first name
- last name
- age
- email
- password
- phone
- address

Example of the data files:
| id | first name | last name | age | email | password | phone | address | role |
|----|------------|-----------|-----|-------|----------|-------|---------|------|
| 1A | admin      | admin     | 30  | admin | admin    | 011111111 | cairo   | admin|
| 1T | teacher    | teacher   | 30  | teacher | teacher | 011111112 | alex | teacher|
| 2T | teacher2   | teacher2  | 30  | teacher2 | teacher2 | 011111113 | mansoura | teacher|
| 3T | teacher3   | teacher3  | 30  | teacher3 | teacher3 | 011111114 | tanta | teacher|
| 1S | student    | student   | 30  | student | student | 011111113 | mansoura | student|
| 2S | student2   | student2  | 30  | student2 | student2 | 011111114 | tanta | student|
| 3S | student3   | student3  | 30  | student3 | student3 | 011111115 | mansoura | student|
| 4S | student4   | student4  | 30  | student4 | student4 | 011111116 | tanta | student|
| 5S | student5   | student5  | 30  | student5 | student5 | 011111117 | mansoura | student|


2- Courses.xml
the file contains the data of all the courses in the system.

each course has its own data:
- course id
- course name
- sessions number
- description

| course id | course name | sessions number | description |
|-----------|-------------|-----------------|-------------|
| 1C        | math        | 8               | math course |
| 2C        | science     | 4               | science course |
| 3C        | physics     | 4               | physics course |
| 4C        | chemistry   | 8               | chemistry course |
| 5C        | biology     | 6               | biology course |


3- Attendance.xml
the file contains the data of the attendance of the students in each course.

each attendance has its own data:
- class id
- course id
- teacher id
- student id
- date
- status

Example of the data files:
| class id | course id | teacher id | student id | date       | status |
|----------|-----------|------------|------------|------------|--------|
| 1CS      | 1C        | 1T         | 2S         | 2022-03-22 | 1      |
| 1CS      | 1C        | 1T         | 2S         | 2022-03-24 | -1     |
| 1CS      | 1C        | 1T         | 2S         | 2022-03-25 | -1     |
| 1CS      | 1C        | 1T         | 2S         | 2022-03-26 | -1     |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-04 | 1      |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-05 | -1     |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-06 | -1     |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-07 | -1     |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-08 | -1     |
| 2CS      | 2C        | 2T         | 3S         | 2023-04-09 | -1     |

4- Configurations.xml
the file contains the data of the configurations of the system.
that allows the system to save the data and backup the data, change the language and the date format 
even if the system is closed the configurations will be saved in the configurations file.

each configuration data:
- name
- version
- description
- created date
- data pathes
    - Users
    - Courses
    - Sessions
- backup pathes
    - Users
    - Courses
    - Sessions
- authors
    - Develper 1 : Donya 
    - Develper 2 : Asmaa
    - Develper 3 : Mohamed
- appSettings
- backup data interval
- language
- date format

# How the project works
The project form application that allows the user to login to the system 
and change the language of the system.
showing the date the application was opened and the time to the backup of the data 

in from the login the user can choose the language 