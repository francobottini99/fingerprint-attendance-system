# Sistema de control de asistencia por huella dactilar

Este programa implementa un sistema de gestión de asistencia para instituciones educativas utilizando un lector de huellas dactilares. El sistema consta de dos componentes principales: el hardware que se encarga de la lectura de huellas y un software de gestión para PC que permite administrar y supervisar la asistencia de los alumnos.

### Autores:
- **Bottini, Franco Nicolas**

## Lector de Huellas Dactilares

El lector de huellas dactilares es el componente esencial del sistema. Utiliza tecnología biométrica para capturar y procesar las huellas dactilares de los alumnos de forma segura. Este dispositivo compacto y fácil de usar garantiza la precisión en la identificación de cada individuo, eliminando la posibilidad de registro de asistencias incorrectas. El microcontrolador Arduino actúa como el cerebro del sistema. Se encarga de gestionar la comunicación con el lector de huellas, almacenar las huellas dactilares de los alumnos y manejar la conexión a la red. Para garantizar la conectividad del sistema, se integra un módulo Ethernet que permite la comunicación con el servidor central. Esto posibilita la transferencia segura de datos, como registros de asistencia y actualizaciones de información de huellas dactilares.

### Funcionalidades Principales

#### Registro de Huellas

El sistema ofrece un proceso de registro de huellas dactilares rápido y seguro durante la configuración inicial. La interfaz intuitiva guía a los administradores a través de este proceso, asegurando la inclusión precisa de cada estudiante en la base de datos.
  
#### Asistencia Automática

Con solo colocar el dedo en el lector, el sistema realiza un seguimiento automático de la asistencia. La respuesta prácticamente instantánea del lector agiliza el proceso, brindando eficiencia en la toma de asistencia diaria.

#### Sincronización Automática

Las actualizaciones de la base de datos se realizan de forma automática mediante sincronizaciones regulares con el servidor central. Esta función garantiza que cualquier cambio en la información del estudiante se refleje de inmediato en todos los terminales del sistema.

#### Gestión de Asistencia

El software de gestión para PC proporciona una interfaz atractiva y fácil de usar. Facilita la administración eficiente de la asistencia, permitiendo a los usuarios generar informes detallados y estadísticas para un análisis profundo.

## Software de Gestión

El componente de software del Sistema de Gestión de Asistencia con Lector de Huellas Dactilares ofrece una interfaz de usuario amigable y completa para administrar de manera integral todos los aspectos del sistema. Diseñado con un enfoque en la facilidad de uso y la eficiencia, permite a diversos usuarios, como administradores y maestros, llevar a cabo una variedad de operaciones con facilidad.

### Funcionalidades Principales

#### Configuración del Terminal

El software simplifica la configuración inicial del terminal, permitiendo a los administradores asignar nombres, configurar direcciones IP y otros parámetros de red de manera sencilla. La interfaz gráfica intuitiva guía a los usuarios a través de este proceso, asegurando una configuración sin complicaciones.

#### Visualización de Asistencia

Ofrece una interfaz gráfica interactiva que permite a los administradores y maestros visualizar la asistencia de los alumnos en tiempo real. Los gráficos intuitivos y los colores representativos proporcionan una visión instantánea del estado de asistencia, facilitando la toma de decisiones. Además, el sistema permite acceder a historiales detallados de asistencia para un seguimiento exhaustivo.

#### Actualización de Datos

El sistema gestiona la actualización automática de la información del servidor central. Esto garantiza la coherencia y confiabilidad de la base de datos, asegurando que cualquier cambio en la información del estudiante se refleje de inmediato en todos los terminales del sistema.

#### Gestión de Horarios

El software incluye una funcionalidad que permite la el registro de horarios. Los administradores pueden establecer y ajustar fácilmente los horarios de clases, actividades extracurriculares y otros eventos relacionados con la asistencia. Ademas, se permite la generación de horarios exepcionales eventos especiales (ausencia de un porfesor) y permite la asignación de feriados y asuetos. Estas características contribuyen a una gestión eficiente del tiempo y recursos en la institución educativa.

#### Alta de Alumnos

Facilita el proceso de alta de alumnos en la base de datos, permitiendo a los administradores agregar nuevos estudiantes de manera rápida y precisa. La interfaz de alta de alumnos es intuitiva, solicitando la información esencial para su inclusión en el sistema.

#### Gestión de Cursos y Grupos

El sistema permite a los administradores gestionar los cursos y grupos de la institución educativa. Se pueden agregar nuevos cursos y subdividirlos en grupos con facilidad. Lo que permite una segmentación eficiente de los horarios y la asistencia.

#### Gestión de Usuarios

El sistema permite a los administradores gestionar los usuarios del sistema, incluidos los maestros y otros administradores. La interfaz de gestión de usuarios es fácil de usar, permitiendo a los administradores agregar, editar y eliminar usuarios con facilidad.

---

Este Sistema de Gestión de Asistencia con Lector de Huellas Dactilares representa una solución completa y eficiente para las instituciones educativas, mejorando la precisión y eficacia en el seguimiento de la asistencia y simplificando las tareas administrativas asociadas.
