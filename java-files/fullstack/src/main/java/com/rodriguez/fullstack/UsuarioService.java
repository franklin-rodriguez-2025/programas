
    package com.rodriguez.fullstack;

    import org.springframework.beans.factory.annotation.Autowired;
    import org.springframework.jdbc.core.JdbcTemplate;
    import org.springframework.stereotype.Service;

    import java.util.List;
    import java.util.Optional;

    @Service
    public class UsuarioService implements ICrudService<Usuario>
    {
        @Autowired
        private JdbcTemplate jdbcTemplate;

        @Autowired
        private UsuarioRepository usuarioRepository;

        @Override
        public Usuario getById(Long id)
        {
            Optional<Usuario> optional = usuarioRepository.findById(id);
            if( optional.isPresent() )
            {
                return optional.get();
            }
            return null;
        }

        @Override
        public List<Usuario> getAll()
        {
            return usuarioRepository.findAll();
        }

        @Override
        public Long save(Usuario entity)
        {
            entity = usuarioRepository.save(entity);
            return entity.getId();
        }

        @Override
        public void update(Usuario entity)
        {
            Usuario usuarioFromDatabase = getById(entity.getId());

            usuarioFromDatabase.setNombre( entity.getNombre() );

            usuarioFromDatabase.setApellido( entity.getApellido() );

            usuarioFromDatabase.setCorreo( entity.getCorreo() );

        }
    }
