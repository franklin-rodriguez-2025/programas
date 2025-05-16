
    package com.rodriguez.fullstack;

    import jakarta.persistence.Column;
    import jakarta.persistence.Entity;
    import jakarta.persistence.Id;
    import jakarta.persistence.Table;
    import lombok.Data;
    import java.io.Serial;
    import java.io.Serializable;

    @Entity
    @Table( name = "USUARIO" )
    @Data
    public class Usuario implements Serializable
    {
        @Serial
        public static final long serialVersionUUID = 9L;

        @Id
        @Column( name = "ID" )
        private Long id;

        @Column( name = "NOMBRE", length = 255)
        private String nombre;

        @Column( name = "APELLIDO", length = 255)
        private String apellido;

        @Column( name = "CORREO", length = 255, unique = true)
        private String correo;

        @Column( name = "CONTRASENA", length = 255)
        private String contrasena;

        public Usuario()
        {
        }
    }
