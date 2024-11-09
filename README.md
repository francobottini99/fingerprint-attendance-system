# Fingerprint Attendance Control System

This program implements an attendance management system for educational institutions using a fingerprint reader. The system consists of two main components: the hardware responsible for fingerprint reading and PC-based management software that allows administrators to manage and supervise student attendance.

### Authors:
- **Bottini, Franco Nicolas**

## Fingerprint Reader

The fingerprint reader is the essential component of the system. It uses biometric technology to capture and process students' fingerprints securely. This compact and easy-to-use device ensures accuracy in identifying each individual, eliminating the possibility of incorrect attendance records. The Arduino microcontroller acts as the brain of the system. It manages communication with the fingerprint reader, stores students' fingerprints, and handles network connectivity. To ensure system connectivity, an Ethernet module is integrated, allowing communication with the central server. This enables secure data transfer, such as attendance logs and fingerprint information updates.

### Main Features

#### Fingerprint Registration

The system offers a fast and secure fingerprint registration process during the initial setup. The intuitive interface guides administrators through this process, ensuring the accurate inclusion of each student in the database.
  
#### Automatic Attendance

By simply placing a finger on the reader, the system automatically tracks attendance. The almost instantaneous response of the reader speeds up the process, providing efficiency in daily attendance recording.

#### Automatic Synchronization

Database updates are automatically performed through regular synchronizations with the central server. This feature ensures that any change in student information is immediately reflected across all system terminals.

#### Attendance Management

The PC management software provides an attractive and easy-to-use interface. It facilitates the efficient management of attendance, allowing users to generate detailed reports and statistics for in-depth analysis.

## Management Software

The software component of the Fingerprint Attendance Management System provides a user-friendly and comprehensive interface to fully manage all aspects of the system. Designed with a focus on ease of use and efficiency, it allows various users, such as administrators and teachers, to carry out a variety of tasks with ease.

### Main Features

#### Terminal Configuration

The software simplifies the initial terminal setup, allowing administrators to easily assign names, configure IP addresses, and other network parameters. The intuitive graphical interface guides users through this process, ensuring a hassle-free configuration.

#### Attendance Visualization

It offers an interactive graphical interface that allows administrators and teachers to view student attendance in real time. Intuitive graphs and representative colors provide an instant view of attendance status, facilitating decision-making. Additionally, the system allows access to detailed attendance histories for thorough monitoring.

#### Data Update

The system manages automatic updates of information to the central server. This ensures the consistency and reliability of the database, ensuring that any change in student information is immediately reflected across all system terminals.

#### Schedule Management

The software includes functionality for registering schedules. Administrators can easily set and adjust class schedules, extracurricular activities, and other events related to attendance. Additionally, it allows the generation of special schedules for exceptional events (e.g., teacher absence) and the assignment of holidays and breaks. These features contribute to efficient time and resource management in the educational institution.

#### Student Enrollment

It facilitates the process of enrolling students in the database, allowing administrators to quickly and accurately add new students. The student enrollment interface is intuitive, asking for essential information for their inclusion in the system.

#### Course and Group Management

The system allows administrators to manage courses and groups in the educational institution. New courses can be added and subdivided into groups easily. This allows efficient segmentation of schedules and attendance.

#### User Management

The system allows administrators to manage system users, including teachers and other administrators. The user management interface is easy to use, enabling administrators to add, edit, and remove users effortlessly.

---

This Fingerprint Attendance Management System represents a complete and efficient solution for educational institutions, improving the accuracy and effectiveness of attendance tracking and simplifying the administrative tasks associated with it.
