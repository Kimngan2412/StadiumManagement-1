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
    public class RentOrderRepository : Repository<RentOrder>
    {
        public List<RentOrderVM> GetList(int Bill_Id)
        {
            List<RentOrder> list = GetAll(c => c.Bill_Id == Bill_Id);
            List<RentOrderVM> listVM = new List<RentOrderVM>();
            foreach (RentOrder s in list)
            {
                listVM.Add(mapper.Map<RentOrderVM>(s));
            }
            return listVM;
        }

        public void AddRentOrder(RentOrderVM rovm)
        {
            if (rovm.Validate().Length == 0)
            {
                if (isValidTime(rovm.Stadium_Id, rovm.StartRentDate, rovm.EndRentDate))
                {
                    RentOrder ro = mapper.Map<RentOrder>(rovm);
                    Add(ro);
                    Save();
                }
                else throw new Exception("Trùng giờ mất rồi !");
            }
            else throw new Exception(rovm.Validate());
        }

        public void UpdateRentOrder(RentOrderVM rovm, DateTime _startBeforeUpdate, DateTime _endBeforeUpdate)
        {
            if (rovm.Validate().Length == 0)
            {
                if (isValidTime(rovm.Stadium_Id, rovm.StartRentDate, rovm.EndRentDate, _startBeforeUpdate, _endBeforeUpdate))
                {
                    RentOrder ro = GetById(rovm.Id);
                    mapper.Map(rovm, ro);
                    Save();
                }
                else throw new Exception("Trùng giờ mất rồi !");
            }
            else throw new Exception(rovm.Validate());
        }

        public void DeleteRentOrder(int id)
        {
            Remove(id);
            Save();
        }

        //Validate dat san
        public string ListRentTime(int stadium_id)
        {
            // Lay list RO cua San, Chi lay nhung RO thuoc Bill chua thanh toan
            IEnumerable<RentOrder> listRO = _db.Stadiums.Find(stadium_id).RentOrders;
            listRO = listRO.Where(c => c.Bill.BillStatus == BillStatus.UnPurchased);

            StringBuilder sb = new StringBuilder();
            foreach (RentOrder ro in listRO)
            {
                sb.Append($"{ro.StartRentDate,22}  => {ro.EndRentDate,22}\n\n");
            }
            return sb.ToString();
        }

        public bool isValidTime(int stadium_id, DateTime _start, DateTime _end,
                                        DateTime? _startBeforeUpdate = null, DateTime? _endBeforeUpdate = null)
        {
            IEnumerable<RentOrder> listRO = _db.Stadiums.Find(stadium_id).RentOrders;
            //Neu la dang cap nhat thi loai di khoang thoi gian hien tai de tranh viec khong cho Update
            if (_startBeforeUpdate != null && _endBeforeUpdate != null)
            {
                //Loai di khoang thoi gian ban dau khi Update, lay not (!)
                // c.StartRentDate == _startBeforeUpdate && c.EndRentDate == _endBeforeUpdate)
                listRO = listRO.Where(c => (c.StartRentDate != _startBeforeUpdate || c.EndRentDate != _endBeforeUpdate)
                && (c.Bill.BillStatus == BillStatus.UnPurchased));
            }
            else
            {
                listRO = listRO.Where(c => c.Bill.BillStatus == BillStatus.UnPurchased);
            }
            //Dieu kien de thoi gian khong hop le => lay ! (not)
            // Them [A;B] vao sao cho no khong co doan nao trung voi cac doan [C;D] cho truoc tru 2 dau mut (A<B,C<D)
            // De [A;B] trung voi 1 doan voi [C;D] thi :
            // C<=A<D (luc nay B nam dau cung duoc) hoac C<B<=D (luc nay A nam dau cung duoc)
            return !listRO.Any(c => (c.StartRentDate.TrimSeconds() <= _start.TrimSeconds()
                                        && _start.TrimSeconds() < c.EndRentDate.TrimSeconds())
                                || (c.StartRentDate.TrimSeconds() < _end.TrimSeconds()
                                        && _end.TrimSeconds() <= c.EndRentDate.TrimSeconds()));
        }
    }
}
