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
    
    
    // Table('DiagnosisLevel') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisLevel : SoftBand.EntityManager.Entity
    {
        
        public DiagnosisLevel()
        {
            this.DefineColumns(3);
        }
        
        public int DiagnosisLevelNumber
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
        
        public string DiagnosisLevelCode
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
        
        public string DiagnosisLevelName
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
        
        public static DiagnosisLevelService Service
        {
            get
            {
                return ((DiagnosisLevelService)(GetServiceObject(typeof(DiagnosisLevel), typeof(DiagnosisLevelService))));
            }
        }
        
        public static DiagnosisLevelSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<DiagnosisLevelSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static DiagnosisLevel GetByKey(int diagnosisLevelNumber)
        {
            return Service.GetByKey(diagnosisLevelNumber);
        }
        
        public static string GetByKeyJson(int diagnosisLevelNumber)
        {
            return Service.GetByKeyJson(diagnosisLevelNumber);
        }
        
        public static async Task<DiagnosisLevel> GetByKeyAsync(int diagnosisLevelNumber)
        {
            return await Service.GetByKeyAsync(diagnosisLevelNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int diagnosisLevelNumber)
        {
            return await Service.GetByKeyJsonAsync(diagnosisLevelNumber);
        }
        
        public static DiagnosisLevel Insert(string diagnosisLevelCode, string diagnosisLevelName)
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Service.Insert(diagnosisLevelCode, diagnosisLevelName);
        }
        
        public static async Task<DiagnosisLevel> InsertAsync(string diagnosisLevelCode, string diagnosisLevelName)
        {
            // InsertAsync ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await Service.InsertAsync(diagnosisLevelCode, diagnosisLevelName);
        }
        
        public new DiagnosisLevel Insert()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return Insert(DiagnosisLevelCode, DiagnosisLevelName);
        }
        
        public async Task<DiagnosisLevel> InsertAsync()
        {
            // Insert ????????? Table Key??? ?????? ???????????? ???????????? ?????? ?????? Table??? 
            // ??????????????? ????????? ??? ????????????
            // 
            return await InsertAsync(DiagnosisLevelCode, DiagnosisLevelName);
        }
        
        public new int Update()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisLevelNumberParam = this.DiagnosisLevelNumber;
            string diagnosisLevelCodeParam = this.DiagnosisLevelCode;
            string diagnosisLevelNameParam = this.DiagnosisLevelName;
            // update ??????
            return Service.Update(diagnosisLevelNumberParam, diagnosisLevelCodeParam, diagnosisLevelNameParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // ????????? ?????? ??????????????? ?????????
            int diagnosisLevelNumberParam = this.DiagnosisLevelNumber;
            string diagnosisLevelCodeParam = this.DiagnosisLevelCode;
            string diagnosisLevelNameParam = this.DiagnosisLevelName;
            return await Service.UpdateAsync(diagnosisLevelNumberParam, diagnosisLevelCodeParam, diagnosisLevelNameParam);
        }
        
        public static int Update(int diagnosisLevelNumber, string diagnosisLevelCode, string diagnosisLevelName)
        {
            return Service.Update(diagnosisLevelNumber, diagnosisLevelCode, diagnosisLevelName);
        }
        
        public static async Task<int> UpdateAsync(int diagnosisLevelNumber, string diagnosisLevelCode, string diagnosisLevelName)
        {
            return await Service.UpdateAsync(diagnosisLevelNumber, diagnosisLevelCode, diagnosisLevelName);
        }
        
        public static int Delete(int diagnosisLevelNumber)
        {
            return Service.Delete(diagnosisLevelNumber);
        }
        
        public static async Task<int> DeleteAsync(int diagnosisLevelNumber)
        {
            return await Service.DeleteAsync(diagnosisLevelNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(DiagnosisLevelNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(DiagnosisLevelNumber);
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
    
    
    // Table('DiagnosisLevel')  Service class
    // Do not add or change code here.
    public partial class DiagnosisLevelService : SoftBand.EntityManager.Service
    {
        
        public DiagnosisLevelSet GetAll()
        {
            return ((DiagnosisLevelSet)(this.GetAll("DiagnosisLevel", typeof(DiagnosisLevelSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("DiagnosisLevel");
        }
        
        public async Task<DiagnosisLevelSet> GetAllAsync()
        {
            return ((DiagnosisLevelSet)(await this.GetAllAsync("DiagnosisLevel", typeof(DiagnosisLevelSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("DiagnosisLevel");
        }
        
        public DiagnosisLevel GetByKey(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(selectCmd, paraNames, diagnosisLevelNumber);
            // 
            DiagnosisLevel entity = ((DiagnosisLevel)(this.GetEntity(selectCmd, typeof(DiagnosisLevelSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(selectCmd, paraNames, diagnosisLevelNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<DiagnosisLevel> GetByKeyAsync(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(selectCmd, paraNames, diagnosisLevelNumber);
            // 
            // GetByKeyAsync ??? ????????????
            DiagnosisLevel entity = ((DiagnosisLevel)(await this.GetEntityAsync(selectCmd, typeof(DiagnosisLevelSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(selectCmd, paraNames, diagnosisLevelNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public DiagnosisLevel Insert(string diagnosisLevelCode, string diagnosisLevelName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisLevel(DiagnosisLevelCode, DiagnosisLevelName) OUTPUT INSERTE" +
                "D.DiagnosisLevelNumber\r\nVALUES (@diagnosisLevelCode, @diagnosisLevelName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelCode,diagnosisLevelName";
            AddParameters(insertCommand, paraNames, diagnosisLevelCode, diagnosisLevelName);
            // 
            // Insert ??? ????????????
            DiagnosisLevel entity = ((DiagnosisLevel)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<DiagnosisLevel> InsertAsync(string diagnosisLevelCode, string diagnosisLevelName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO DiagnosisLevel(DiagnosisLevelCode, DiagnosisLevelName) OUTPUT INSERTE" +
                "D.DiagnosisLevelNumber\r\nVALUES (@diagnosisLevelCode, @diagnosisLevelName) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelCode,diagnosisLevelName";
            AddParameters(insertCommand, paraNames, diagnosisLevelCode, diagnosisLevelName);
            // 
            // InsertAsync ??? ????????????
            DiagnosisLevel entity = ((DiagnosisLevel)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int diagnosisLevelNumber, string diagnosisLevelCode, string diagnosisLevelName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisLevel SET DiagnosisLevelCode = @diagnosisLevelCode, DiagnosisLeve" +
                "lName = @diagnosisLevelName WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber,diagnosisLevelCode,diagnosisLevelName";
            AddParameters(updateCmd, paraNames, diagnosisLevelNumber, diagnosisLevelCode, diagnosisLevelName);
            // 
            // Update ??? ????????????
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int diagnosisLevelNumber, string diagnosisLevelCode, string diagnosisLevelName)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE DiagnosisLevel SET DiagnosisLevelCode = @diagnosisLevelCode, DiagnosisLeve" +
                "lName = @diagnosisLevelName WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber,diagnosisLevelCode,diagnosisLevelName";
            AddParameters(updateCmd, paraNames, diagnosisLevelNumber, diagnosisLevelCode, diagnosisLevelName);
            // 
            // Update ??? ????????????
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(deleteCmd, paraNames, diagnosisLevelNumber);
            // 
            // Delete ??? ????????????
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int diagnosisLevelNumber)
        {
            // IDbCommand ?????????
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM DiagnosisLevel WHERE DiagnosisLevelNumber = @diagnosisLevelNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "diagnosisLevelNumber";
            AddParameters(deleteCmd, paraNames, diagnosisLevelNumber);
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
    
    
    // Table('DiagnosisLevel') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class DiagnosisLevelSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public DiagnosisLevelSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected DiagnosisLevelSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected DiagnosisLevelSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public DiagnosisLevelBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(DiagnosisLevel);
        }
        
        private DiagnosisLevelBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private DiagnosisLevelBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((DiagnosisLevelBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(DiagnosisLevelBoundCollection))));
        }
        
        public partial class DiagnosisLevelBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new DiagnosisLevel this[int index]
            {
                get
                {
                    return ((DiagnosisLevel)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
