﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceReservasi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string pemesanan(string IDPemesanan, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDLokasi);
        [OperationContract]
        string editPemesanan(string IDPemesanan, string NamaCustomer, string No_telpon);
        [OperationContract]
        string deletPemesanan(string IDPemesanan);
        [OperationContract]
        List<CekLokasi> ReviewLokasi(); //menampilkan data yg ada di database (select all) //menampilkan isi dari yang ada contract
        [OperationContract]
        List<DetailLokasi> DetailLokasi(); //menampilkan detail lokasi
        [OperationContract]
        List<Pemesanan> Pemesanan();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceReservasi.ContractType".
    [DataContract]
    public class CekLokasi //daftar lokasi nongkrong
    {
        
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiSingkat { get; set; }
    }
    [DataContract]
    public class DetailLokasi //menampilkan detail Lokasi
    {
        [DataMember]
        public string IDLokasi { get; set; } //variabel dari public class
        [DataMember]
        public string NamaLokasi { get; set; }
        [DataMember]
        public string DeskripsiSingkat { get; set; }
        [DataMember]
        public int Kuota { get; set; }
        public string DeskripsiFull { get; internal set; }
    }
    [DataContract]
    public class Pemesanan //create
    {
        [DataMember]
        public string IDPemesanan { get; set; } //variabel dari public class
        [DataMember]
        public string NamaCustomer { get; set; }
        [DataMember]
        public string NoTelpon { get; set; }
        [DataMember]
        public int Jumlahpemesanan { get; set; }
        [DataMember]
        public string Lokasi { get; set; }
    }
}
