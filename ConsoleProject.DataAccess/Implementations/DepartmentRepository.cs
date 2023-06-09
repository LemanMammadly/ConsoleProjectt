﻿using ConsoleProject.Core.Entities;
using ConsoleProject.DataAccess.Contexts;
using ConsoleProject.DataAccess.Interfaces;

namespace ConsoleProject.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DbContext.Departments.Add(entity);
    }

    public void Delete(int id)
    {
        Department department = DbContext.Departments.Find(d => d.Id == id);
        DbContext.Departments.Remove(department);
    }

    public void Update(Department entity)
    {
        Department department=DbContext.Departments.Find(d=>d.Id==entity.Id);
        department.DepartmentName = entity.DepartmentName;
        department.EmployeeLimit = entity.EmployeeLimit;
    }

    public Department? Get(int id)
    {
        return DbContext.Departments.Find(d => d.Id == id);
    }

    public Department? GetByName(string departmentname)
    {
        return DbContext.Departments.Find(d => d.DepartmentName == departmentname);
    }

    public List<Department> GetCompaniesId(int id)
    {
        return DbContext.Departments.FindAll(d=>d.CompanyId==id);
    }

    public List<Department> GetAll()
    {
        return DbContext.Departments;
    }
}

