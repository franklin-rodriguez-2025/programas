
    package com.rodriguez.fullstack;

    import java.util.List;

    public interface ICrudService<T>
    {
        T getById(Long id);

        List<T> getAll();

        Long save(T entity);

        void update(T entity);
    }
