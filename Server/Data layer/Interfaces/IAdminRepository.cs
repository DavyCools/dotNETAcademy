﻿using Data_layer.Model;

namespace Data_layer.Interfaces
{
    public interface IAdminRepository
    {
        Admin GetAdminByID(string adminId);
        Admin CreateAdmin(Admin admin);
        Admin DeleteAdmin(string AdminId);
        void SaveChanges();
    }
}
