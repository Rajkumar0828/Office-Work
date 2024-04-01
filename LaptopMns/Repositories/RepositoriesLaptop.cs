using LaptopManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LaptopManagementSystem.Repositories
{
    public class LaptopRepository
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public LaptopRepository()
        {
            string connectionString = @"server=127.0.0.1;user=root;database=LaptopManagementSystem;port=3306;password=Password@12345";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Laptop> GetLaptops()
        {
            string sql = "SELECT * FROM LAPTOP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Laptop> laptops = new List<Laptop>();
            while (this.reader.Read())
            {
                Laptop laptop = new Laptop();
                laptop.LaptopId = int.Parse(this.reader["LaptopId"].ToString());
                laptop.BrandId = int.Parse(this.reader["BrandId"].ToString());
                laptop.ModelId = int.Parse(this.reader["ModelId"].ToString());
                laptop.ProcessorId = int.Parse(this.reader["ProcessorId"].ToString());
                laptop.RAMId = int.Parse(this.reader["RAMId"].ToString());
                laptop.SerialNumber = this.reader["SerialNumber"].ToString();
                laptop.PurchaseDate = DateTime.Parse(this.reader["PurchaseDate"].ToString());
                laptops.Add(laptop);
            }
            this.reader.Close();
            this.cn.Close();
            return laptops;
        }

        public Laptop FindLaptop(int id)
        {
            string sql = "SELECT * FROM LAPTOP WHERE LaptopId=@LaptopId";
            SqlParameter pamid = new SqlParameter("@LaptopId", id);
            this.com.Parameters.Add(pamid);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.reader.Read();
            Laptop laptop = new Laptop();
            laptop.LaptopId = int.Parse(this.reader["LaptopId"].ToString());
            laptop.BrandId = int.Parse(this.reader["BrandId"].ToString());
            laptop.ModelId = int.Parse(this.reader["ModelId"].ToString());
            laptop.ProcessorId = int.Parse(this.reader["ProcessorId"].ToString());
            laptop.RAMId = int.Parse(this.reader["RAMId"].ToString());
            laptop.SerialNumber = this.reader["SerialNumber"].ToString();
            laptop.PurchaseDate = DateTime.Parse(this.reader["PurchaseDate"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return laptop;
        }

        public void InsertLaptop(int brandId, int modelId, int processorId, int ramId, string serialNumber, DateTime purchaseDate)
        {
            string sql = "INSERT INTO LAPTOP VALUES (@BrandId, @ModelId, @ProcessorId, @RAMId, @SerialNumber, @PurchaseDate)";
            SqlParameter pambrand = new SqlParameter("@BrandId", brandId);
            SqlParameter pammodel = new SqlParameter("@ModelId", modelId);
            SqlParameter pamprocessor = new SqlParameter("@ProcessorId", processorId);
            SqlParameter pamram = new SqlParameter("@RAMId", ramId);
            SqlParameter pamserialNumber = new SqlParameter("@SerialNumber", serialNumber);
            SqlParameter pampurchaseDate = new SqlParameter("@PurchaseDate", purchaseDate);
            this.com.Parameters.Add(pambrand);
            this.com.Parameters.Add(pammodel);
            this.com.Parameters.Add(pamprocessor);
            this.com.Parameters.Add(pamram);
            this.com.Parameters.Add(pamserialNumber);
            this.com.Parameters.Add(pampurchaseDate);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        public void UpdateLaptop(int id, int brandId, int modelId, int processorId, int ramId, string serialNumber, DateTime purchaseDate)
        {
            string sql = "UPDATE LAPTOP SET BrandId=@BrandId, ModelId=@ModelId, ProcessorId=@ProcessorId, RAMId=@RAMId, SerialNumber=@SerialNumber, PurchaseDate=@PurchaseDate WHERE LaptopId=@ID";
            SqlParameter pamid = new SqlParameter("@ID", id);
            SqlParameter pambrand = new SqlParameter("@BrandId", brandId);
            SqlParameter pammodel = new SqlParameter("@ModelId", modelId);
            SqlParameter pamprocessor = new SqlParameter("@ProcessorId", processorId);
            SqlParameter pamram = new SqlParameter("@RAMId", ramId);
            SqlParameter pamserialNumber = new SqlParameter("@SerialNumber", serialNumber);
            SqlParameter pampurchaseDate = new SqlParameter("@PurchaseDate", purchaseDate);
            this.com.Parameters.Add(pamid);
            this.com.Parameters.Add(pambrand);
            this.com.Parameters.Add(pammodel);
            this.com.Parameters.Add(pamprocessor);
            this.com.Parameters.Add(pamram);
            this.com.Parameters.Add(pamserialNumber);
            this.com.Parameters.Add(pampurchaseDate);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.cn.Close();
            this.com.Parameters.Clear();
        }

        public void DeleteLaptop(int id)
        {
            string sql = "DELETE FROM LAPTOP WHERE LaptopId=@ID";
            SqlParameter pamid = new SqlParameter("@ID", id);
            this.com.Parameters.Add(pamid);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}