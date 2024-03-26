﻿using Entities;

namespace DataAccess
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}