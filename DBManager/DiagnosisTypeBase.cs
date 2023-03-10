//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisType') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisType : SoftBand.EntityManager.Entity
    {
        
        public DiagnosisType()
        {
            this.DefineColumns(3);
        }
        
        public int DiagnosisTypeNumber
        {
            get
            {
                return ((int)(this[0]));
            }
            set
            {
                this[0] = value;
            }
        }
        
        public string DiagnosisTypeCode
        {
            get
            {
                return ((string)(this[1]));
            }
            set
            {
                this[1] = value;
            }
        }
        
        public string DiagnosisTypeName
        {
            get
            {
                return ((string)(this[2]));
            }
            set
            {
                this[2] = value;
            }
        }
        
        public static DiagnosisTypeService Service
        {
            get
            {
                return ((DiagnosisTypeService)(GetServiceObject(typeof(DiagnosisType), typeof(DiagnosisTypeService))));
            }
        }
        
        public static DiagnosisTypeSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<DiagnosisTypeSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static DiagnosisType GetByKey(int diagnosisTypeNumber)
        {
            return Service.GetByKey(diagnosisTypeNumber);
        }
        
        public static string GetByKeyJson(int diagnosisTypeNumber)
        {
            return Service.GetByKeyJson(diagnosisTypeNumber);
        }
        
        public static async Task<DiagnosisType> GetByKeyAsync(int diagnosisTypeNumber)
        {
            return await Service.GetByKeyAsync(diagnosisTypeNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int diagnosisTypeNumber)
        {
            return await Service.GetByKeyJsonAsync(diagnosisTypeNumber);
        }
        
        public static DiagnosisType Insert(string diagnosisTypeCode, string diagnosisTypeName)
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Service.Insert(diagnosisTypeCode, diagnosisTypeName);
        }
        
        public static async Task<DiagnosisType> InsertAsync(string diagnosisTypeCode, string diagnosisTypeName)
        {
            // InsertAsync ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await Service.InsertAsync(diagnosisTypeCode, diagnosisTypeName);
        }
        
        public new DiagnosisType Insert()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Insert(DiagnosisTypeCode, DiagnosisTypeName);
        }
        
        public async Task<DiagnosisType> InsertAsync()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await InsertAsync(DiagnosisTypeCode, DiagnosisTypeName);
        }
        
        public new int Update()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisTypeNumberParam = this.DiagnosisTypeNumber;
            string diagnosisTypeCodeParam = this.DiagnosisTypeCode;
            string diagnosisTypeNameParam = this.DiagnosisTypeName;
            // update ??????
            return Service.Update(diagnosisTypeNumberParam, diagnosisTypeCodeParam, diagnosisTypeNameParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisTypeNumberParam = this.DiagnosisTypeNumber;
            string diagnosisTypeCodeParam = this.DiagnosisTypeCode;
            string diagnosisTypeNameParam = this.DiagnosisTypeName;
            return await Service.UpdateAsync(diagnosisTypeNumberParam, diagnosisTypeCodeParam, diagnosisTypeNameParam);
        }
        
        public static int Update(int diagnosisTypeNumber, string diagnosisTypeCode, string diagnosisTypeName)
        {
            return Service.Update(diagnosisTypeNumber, diagnosisTypeCode, diagnosisTypeName);
        }
        
        public static async Task<int> UpdateAsync(int diagnosisTypeNumber, string diagnosisTypeCode, string diagnosisTypeName)
        {
            return await Service.UpdateAsync(diagnosisTypeNumber, diagnosisTypeCode, diagnosisTypeName);
        }
        
        public static int Delete(int diagnosisTypeNumber)
        {
            return Service.Delete(diagnosisTypeNumber);
        }
        
        public static async Task<int> DeleteAsync(int diagnosisTypeNumber)
        {
            return await Service.DeleteAsync(diagnosisTypeNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(DiagnosisTypeNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(DiagnosisTypeNumber);
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisType')  Service class
    // Do not add or change code here.
    public partial class DiagnosisTypeService : SoftBand.EntityManager.Service
    {
        
        public DiagnosisTypeSet GetAll()
        {
            return ((DiagnosisTypeSet)(this.GetAll("DiagnosisType", typeof(DiagnosisTypeSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("DiagnosisType");
        }
        
        public async Task<DiagnosisTypeSet> GetAllAsync()
        {
            return ((DiagnosisTypeSet)(await this.GetAllAsync("DiagnosisType", typeof(DiagnosisTypeSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("DiagnosisType");
        }
        
        public DiagnosisType GetByKey(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            // 
            DiagnosisType entity = ((DiagnosisType)(this.GetEntity(selectCmd, typeof(DiagnosisTypeSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<DiagnosisType> GetByKeyAsync(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            // 
            // GetByKeyAsync ??? ????????????
            DiagnosisType entity = ((DiagnosisType)(await this.GetEntityAsync(selectCmd, typeof(DiagnosisTypeSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(selectCmd, paraNames, diagnosisTypeNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public DiagnosisType Insert(string diagnosisTypeCode, string diagnosisTypeName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisType(DiagnosisTypeCode, DiagnosisTypeName) OUTPUT INSERTED.D" +
                "iagnosisTypeNumber\r\nVALUES (@diagnosisTypeCode, @diagnosisTypeName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeCode,diagnosisTypeName";
            AddParameters(insertCommand, paraNames, diagnosisTypeCode, diagnosisTypeName);
            // 
            // Insert ??? ????????????
            DiagnosisType entity = ((DiagnosisType)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<DiagnosisType> InsertAsync(string diagnosisTypeCode, string diagnosisTypeName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisType(DiagnosisTypeCode, DiagnosisTypeName) OUTPUT INSERTED.D" +
                "iagnosisTypeNumber\r\nVALUES (@diagnosisTypeCode, @diagnosisTypeName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeCode,diagnosisTypeName";
            AddParameters(insertCommand, paraNames, diagnosisTypeCode, diagnosisTypeName);
            // 
            // InsertAsync ??? ????????????
            DiagnosisType entity = ((DiagnosisType)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int diagnosisTypeNumber, string diagnosisTypeCode, string diagnosisTypeName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisType SET DiagnosisTypeCode = @diagnosisTypeCode, DiagnosisTypeNam" +
                "e = @diagnosisTypeName WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber,diagnosisTypeCode,diagnosisTypeName";
            AddParameters(updateCmd, paraNames, diagnosisTypeNumber, diagnosisTypeCode, diagnosisTypeName);
            // 
            // Update ??? ????????????
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int diagnosisTypeNumber, string diagnosisTypeCode, string diagnosisTypeName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisType SET DiagnosisTypeCode = @diagnosisTypeCode, DiagnosisTypeNam" +
                "e = @diagnosisTypeName WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber,diagnosisTypeCode,diagnosisTypeName";
            AddParameters(updateCmd, paraNames, diagnosisTypeNumber, diagnosisTypeCode, diagnosisTypeName);
            // 
            // Update ??? ????????????
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(deleteCmd, paraNames, diagnosisTypeNumber);
            // 
            // Delete ??? ????????????
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int diagnosisTypeNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisType WHERE DiagnosisTypeNumber = @diagnosisTypeNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisTypeNumber";
            AddParameters(deleteCmd, paraNames, diagnosisTypeNumber);
            // 
            // Delete ??? ????????????
            int executeCnt = await this.ExecuteNonQueryAsync(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbManager
{
    using System;
    using System.Runtime.Serialization;
    using System.Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Transactions;
    using SoftBand.EntityManager;
    
    
    // Table('DiagnosisType') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisTypeSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public DiagnosisTypeSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected DiagnosisTypeSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected DiagnosisTypeSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public DiagnosisTypeBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(DiagnosisType);
        }
        
        private DiagnosisTypeBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private DiagnosisTypeBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((DiagnosisTypeBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(DiagnosisTypeBoundCollection))));
        }
        
        public partial class DiagnosisTypeBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new DiagnosisType this[int index]
            {
                get
                {
                    return ((DiagnosisType)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
