<p>En la parte de <strong>Utilidades</strong> se encuentra el script de base de datos para SQL Server.</p>

<h2>Demostración con capturas de pantalla del sistema en funcionamiento</h2>
<h3>Login:</h3>
<img width="503" height="490" alt="Login" src="https://github.com/user-attachments/assets/421f9fc1-82d3-4932-8b1f-a08a996f3a5a" />

<h3>Dashboard:</h3>
<img width="740" height="453" alt="Dashboard" src="https://github.com/user-attachments/assets/e106b6b6-fe82-4f63-9dc7-8863211521e8" />

<h3>Agregar Usuario:</h3>
<img width="1049" height="851" alt="Agregar Usuario" src="https://github.com/user-attachments/assets/9ed52e42-c6e5-45b5-ad45-480a7fcdcbc5" />

<h3>Actualización del usuario en Lista de Usuarios:</h3>
<img width="841" height="467" alt="Lista Usuarios Actualizada" src="https://github.com/user-attachments/assets/98e9c25e-fb66-4eec-8a81-bb20ae04fc7f" />

<h3>Editar Usuario:</h3>
<img width="972" height="940" alt="Editar Usuario" src="https://github.com/user-attachments/assets/226e6fd8-2864-410f-a7c0-c8a5786eae2d" />

<h3>Aviso de verificación antes de eliminar:</h3>
<img width="973" height="640" alt="Verificación de eliminación" src="https://github.com/user-attachments/assets/8e857add-e2d3-479a-877f-14fb58fd7d4d" />

<h3>Mensaje de usuario eliminado:</h3>
<img width="909" height="559" alt="Usuario Eliminado" src="https://github.com/user-attachments/assets/80d0c45f-06c8-477d-a638-7699e8083506" />

<h3>Centro de Control de Usuarios(Después de la eliminación usuario):</h3>
<img width="892" height="522" alt="Centro Control Usuarios" src="https://github.com/user-attachments/assets/c3129eaa-9751-4fc6-aff7-41c37ce80e3d" />

<h3>Centro de Control de Roles:</h3>
<img width="731" height="477" alt="Centro Control Roles" src="https://github.com/user-attachments/assets/9c77c94c-4c4c-4850-9000-ebfe2eb37a5b" />

<h3>Agregar Rol con aviso de éxito:</h3>
<img width="824" height="679" alt="Agregar Rol" src="https://github.com/user-attachments/assets/36a0f6b1-bffb-4407-9bf6-8db811ae1a03" />

<h3>Actualización del centro de control de roles:</h3>
<img width="745" height="491" alt="Actualizar Roles" src="https://github.com/user-attachments/assets/94249fbf-cb57-42b9-947b-77c13934ecab" />

<h3>Edición de rol con aviso de éxito:</h3>
<img width="889" height="697" alt="Editar Rol" src="https://github.com/user-attachments/assets/426fb3e0-46b2-4fb7-b05d-58ed032544d7" />

<h3>Centro de control de roles actualizado:</h3>
<img width="742" height="608" alt="Roles Actualizados" src="https://github.com/user-attachments/assets/44ea62ea-74de-4122-b930-e4f88945b801" />

<h3>Eliminación de rol con confirmación:</h3>
<img width="738" height="478" alt="Eliminar Rol" src="https://github.com/user-attachments/assets/75362de4-f9d9-41de-9d72-84b0b84eb60d" />

<h3>Aviso de eliminación exitosa:</h3>
<img width="721" height="443" alt="Eliminación Exitosa" src="https://github.com/user-attachments/assets/ed3a7bdc-d11b-4994-a9fc-e5c7bb3d8d4e" />

<h3>Centro de control de roles actualizado nuevamente:</h3>
<img width="717" height="459" alt="Control Roles Actualizado Final" src="https://github.com/user-attachments/assets/e80e818b-949f-45a6-aaf1-768a2075def7" />

<hr>

<h2>Sistema CRUD de Gestión de Usuarios y Roles (WinForms con Entity Framework Core)</h2>

<p>
Este proyecto es un sistema de gestión básico (CRUD - Crear, Leer, Actualizar, Eliminar) desarrollado en una aplicación de escritorio 
<strong>Windows Forms (WinForms)</strong>, utilizando <strong>Entity Framework Core (EF Core)</strong> como ORM para interactuar con una base de datos 
<strong>SQL Server</strong>.
</p>

<p>El sistema está construido con una <strong>arquitectura en capas</strong> para mejorar la organización del proyecto y la mantenibilidad.</p>

<h2>Características Principales</h2>
<ul>
    <li><strong>Gestión de Usuarios:</strong> Crear, visualizar, editar y eliminar usuarios.</li>
    <li><strong>Gestión de Roles:</strong> CRUD completo para roles como Administrador, Vendedor, etc.</li>
    <li><strong>Relación 1:N:</strong> Un rol puede tener múltiples usuarios asignados.</li>
    <li><strong>Validaciones:</strong> Manejo de validaciones en formularios.</li>
    <li><strong>Fecha de Ingreso Automática:</strong> Se registra al crear un usuario.</li>
    <li><strong>Unicidad de Roles:</strong> No permite roles duplicados.</li>
    <li><strong>SQL Server:</strong> Base de datos robusta y segura.</li>
    <li><strong>Entity Framework Core:</strong> Gestión de migraciones y mapeo Objeto-Relacional.</li>
    <li><strong>Arquitectura en Capas:</strong>
        <ul>
            <li><strong>Presentación:</strong> Formularios WinForms.</li>
            <li><strong>Negocio:</strong> Controladores y lógica del sistema.</li>
            <li><strong>Datos:</strong> Modelos, DbContext y configuración de EF Core.</li>
        </ul>
    </li>
</ul>

