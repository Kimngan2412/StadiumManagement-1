﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.ViewModels;
using DataAccessLayer;
using DataAccessLayer.Enums;
using DataAccessLayer.Models;

namespace BusinessLayer.Repository
{
    public class ServiceOrderRepository : Repository<ServiceOrder>
    {
        public List<ServiceOrderVM> GetList(int Bill_Id)
        {
            List<ServiceOrder> list = GetAll(c=>c.Bill_Id==Bill_Id);
            List<ServiceOrderVM> listVM = new List<ServiceOrderVM>();
            foreach (ServiceOrder s in list)
            {
                listVM.Add(mapper.Map<ServiceOrderVM>(s));
            }
            return listVM;
        }

        public void AddServiceOrder(ServiceOrderVM sovm)
        {
            sovm.Total = sovm.Service_Price * sovm.Count;
            ServiceOrder so = mapper.Map<ServiceOrder>(sovm);
            Add(so);
            Save();
        }

        public void UpdateServiceOrder(ServiceOrderVM sovm)
        {
            ServiceOrder so = GetById(sovm.Id);
            sovm.Total = sovm.Service_Price * sovm.Count;
            mapper.Map(sovm, so);
            Save();
        }

        public void DeleteServiceOrder(int id)
        {
            Remove(id);
            Save();
        }
    }
}
