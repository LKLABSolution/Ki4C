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
    
    
    // Table('EvaluationSelection') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class EvaluationSelection : SoftBand.EntityManager.Entity
    {
        
        public EvaluationSelection()
        {
            this.DefineColumns(8);
        }
        
        public int EvaluationSelectionNumber
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
        
        public int EvaluationAnswerNumber
        {
            get
            {
                return ((int)(this[1]));
            }
            set
            {
                this[1] = value;
            }
        }
        
        public string UserId
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
        
        public string EvaluationName
        {
            get
            {
                return ((string)(this[3]));
            }
            set
            {
                this[3] = value;
            }
        }
        
        public string EvaluationAooliation
        {
            get
            {
                return ((string)(this[4]));
            }
            set
            {
                this[4] = value;
            }
        }
        
        public System.DateTime EvaluationApplicationDate
        {
            get
            {
                return ((System.DateTime)(this[5]));
            }
            set
            {
                this[5] = value;
            }
        }
        
        public string EvaluationApplicationStatus
        {
            get
            {
                return ((string)(this[6]));
            }
            set
            {
                this[6] = value;
            }
        }
        
        public System.DateTime EvaluationApplicationSelectionStatus
        {
            get
            {
                return ((System.DateTime)(this[7]));
            }
            set
            {
                this[7] = value;
            }
        }
        
        public static EvaluationSelectionService Service
        {
            get
            {
                return ((EvaluationSelectionService)(GetServiceObject(typeof(EvaluationSelection), typeof(EvaluationSelectionService))));
            }
        }
        
        public static EvaluationSelectionSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<EvaluationSelectionSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static EvaluationSelectionSet GetForDiagnosisEvaluationAnswer(int evaluationAnswerNumber)
        {
            return Service.GetForDiagnosisEvaluationAnswer(evaluationAnswerNumber);
        }
        
        public static EvaluationSelectionSet GetForAspNetUsers(string userId)
        {
            return Service.GetForAspNetUsers(userId);
        }
        
        public static async Task<EvaluationSelectionSet> GetForDiagnosisEvaluationAnswerAsync(int evaluationAnswerNumber)
        {
            return await Service.GetForDiagnosisEvaluationAnswerAsync(evaluationAnswerNumber);
        }
        
        public static async Task<EvaluationSelectionSet> GetForAspNetUsersAsync(string userId)
        {
            return await Service.GetForAspNetUsersAsync(userId);
        }
        
        public static string GetForDiagnosisEvaluationAnswerJson(int evaluationAnswerNumber)
        {
            return Service.GetForDiagnosisEvaluationAnswerJson(evaluationAnswerNumber);
        }
        
        public static string GetForAspNetUsersJson(string userId)
        {
            return Service.GetForAspNetUsersJson(userId);
        }
        
        public static async Task<string> GetForDiagnosisEvaluationAnswerJsonAsync(int evaluationAnswerNumber)
        {
            return await Service.GetForDiagnosisEvaluationAnswerJsonAsync(evaluationAnswerNumber);
        }
        
        public static async Task<string> GetForAspNetUsersJsonAsync(string userId)
        {
            return await Service.GetForAspNetUsersJsonAsync(userId);
        }
        
        public static EvaluationSelection GetByKey(int evaluationSelectionNumber)
        {
            return Service.GetByKey(evaluationSelectionNumber);
        }
        
        public static string GetByKeyJson(int evaluationSelectionNumber)
        {
            return Service.GetByKeyJson(evaluationSelectionNumber);
        }
        
        public static async Task<EvaluationSelection> GetByKeyAsync(int evaluationSelectionNumber)
        {
            return await Service.GetByKeyAsync(evaluationSelectionNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int evaluationSelectionNumber)
        {
            return await Service.GetByKeyJsonAsync(evaluationSelectionNumber);
        }
        
        public static EvaluationSelection Insert(int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Service.Insert(evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
        }
        
        public static async Task<EvaluationSelection> InsertAsync(int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // InsertAsync 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await Service.InsertAsync(evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
        }
        
        public new EvaluationSelection Insert()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Insert(EvaluationAnswerNumber, UserId, EvaluationName, EvaluationAooliation, EvaluationApplicationDate, EvaluationApplicationStatus, EvaluationApplicationSelectionStatus);
        }
        
        public async Task<EvaluationSelection> InsertAsync()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await InsertAsync(EvaluationAnswerNumber, UserId, EvaluationName, EvaluationAooliation, EvaluationApplicationDate, EvaluationApplicationStatus, EvaluationApplicationSelectionStatus);
        }
        
        public new int Update()
        {
            // 인수를 해당 파라메타에 옮긴다
            int evaluationSelectionNumberParam = this.EvaluationSelectionNumber;
            int evaluationAnswerNumberParam = this.EvaluationAnswerNumber;
            string userIdParam = this.UserId;
            string evaluationNameParam = this.EvaluationName;
            string evaluationAooliationParam = this.EvaluationAooliation;
            System.DateTime evaluationApplicationDateParam = this.EvaluationApplicationDate;
            string evaluationApplicationStatusParam = this.EvaluationApplicationStatus;
            System.DateTime evaluationApplicationSelectionStatusParam = this.EvaluationApplicationSelectionStatus;
            // update 실행
            return Service.Update(evaluationSelectionNumberParam, evaluationAnswerNumberParam, userIdParam, evaluationNameParam, evaluationAooliationParam, evaluationApplicationDateParam, evaluationApplicationStatusParam, evaluationApplicationSelectionStatusParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // 인수를 해당 파라메타에 옮긴다
            int evaluationSelectionNumberParam = this.EvaluationSelectionNumber;
            int evaluationAnswerNumberParam = this.EvaluationAnswerNumber;
            string userIdParam = this.UserId;
            string evaluationNameParam = this.EvaluationName;
            string evaluationAooliationParam = this.EvaluationAooliation;
            System.DateTime evaluationApplicationDateParam = this.EvaluationApplicationDate;
            string evaluationApplicationStatusParam = this.EvaluationApplicationStatus;
            System.DateTime evaluationApplicationSelectionStatusParam = this.EvaluationApplicationSelectionStatus;
            return await Service.UpdateAsync(evaluationSelectionNumberParam, evaluationAnswerNumberParam, userIdParam, evaluationNameParam, evaluationAooliationParam, evaluationApplicationDateParam, evaluationApplicationStatusParam, evaluationApplicationSelectionStatusParam);
        }
        
        public static int Update(int evaluationSelectionNumber, int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            return Service.Update(evaluationSelectionNumber, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
        }
        
        public static async Task<int> UpdateAsync(int evaluationSelectionNumber, int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            return await Service.UpdateAsync(evaluationSelectionNumber, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
        }
        
        public static int Delete(int evaluationSelectionNumber)
        {
            return Service.Delete(evaluationSelectionNumber);
        }
        
        public static async Task<int> DeleteAsync(int evaluationSelectionNumber)
        {
            return await Service.DeleteAsync(evaluationSelectionNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(EvaluationSelectionNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(EvaluationSelectionNumber);
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
    
    
    // Table('EvaluationSelection')  Service class
    // Do not add or change code here.
    public partial class EvaluationSelectionService : SoftBand.EntityManager.Service
    {
        
        public EvaluationSelectionSet GetAll()
        {
            return ((EvaluationSelectionSet)(this.GetAll("EvaluationSelection", typeof(EvaluationSelectionSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("EvaluationSelection");
        }
        
        public async Task<EvaluationSelectionSet> GetAllAsync()
        {
            return ((EvaluationSelectionSet)(await this.GetAllAsync("EvaluationSelection", typeof(EvaluationSelectionSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("EvaluationSelection");
        }
        
        public EvaluationSelectionSet GetForDiagnosisEvaluationAnswer(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE EvaluationAnswerNumber = @evaluationAns" +
                "werNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            EvaluationSelectionSet entitySet = ((EvaluationSelectionSet)(this.GetEntitySet(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public EvaluationSelectionSet GetForAspNetUsers(string userId)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE UserId = @userId";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "userId";
            AddParameters(selectCmd, paraNames, userId);
            EvaluationSelectionSet entitySet = ((EvaluationSelectionSet)(this.GetEntitySet(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public async Task<EvaluationSelectionSet> GetForDiagnosisEvaluationAnswerAsync(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE EvaluationAnswerNumber = @evaluationAns" +
                "werNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            EvaluationSelectionSet entitySet = ((EvaluationSelectionSet)(await this.GetEntitySetAsync(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public async Task<EvaluationSelectionSet> GetForAspNetUsersAsync(string userId)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE UserId = @userId";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "userId";
            AddParameters(selectCmd, paraNames, userId);
            EvaluationSelectionSet entitySet = ((EvaluationSelectionSet)(await this.GetEntitySetAsync(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public string GetForDiagnosisEvaluationAnswerJson(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE EvaluationAnswerNumber = @evaluationAns" +
                "werNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            return  this.GetJsonDataSet(selectCmd);
        }
        
        public string GetForAspNetUsersJson(string userId)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE UserId = @userId";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "userId";
            AddParameters(selectCmd, paraNames, userId);
            return  this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<string> GetForDiagnosisEvaluationAnswerJsonAsync(int evaluationAnswerNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE EvaluationAnswerNumber = @evaluationAns" +
                "werNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "evaluationAnswerNumber";
            AddParameters(selectCmd, paraNames, evaluationAnswerNumber);
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public async Task<string> GetForAspNetUsersJsonAsync(string userId)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationSelection] WHERE UserId = @userId";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "userId";
            AddParameters(selectCmd, paraNames, userId);
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public EvaluationSelection GetByKey(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSe" +
                "lectionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(selectCmd, paraNames, evaluationSelectionNumber);
            // 
            EvaluationSelection entity = ((EvaluationSelection)(this.GetEntity(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSe" +
                "lectionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(selectCmd, paraNames, evaluationSelectionNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<EvaluationSelection> GetByKeyAsync(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSe" +
                "lectionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(selectCmd, paraNames, evaluationSelectionNumber);
            // 
            // GetByKeyAsync 를 호출한다
            EvaluationSelection entity = ((EvaluationSelection)(await this.GetEntityAsync(selectCmd, typeof(EvaluationSelectionSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSe" +
                "lectionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(selectCmd, paraNames, evaluationSelectionNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public EvaluationSelection Insert(int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = @"INSERT INTO EvaluationSelection(EvaluationAnswerNumber, UserId, EvaluationName, EvaluationAooliation, EvaluationApplicationDate, EvaluationApplicationStatus, EvaluationApplicationSelectionStatus) OUTPUT INSERTED.EvaluationSelectionNumber
VALUES (@evaluationAnswerNumber, @userId, @evaluationName, @evaluationAooliation, @evaluationApplicationDate, @evaluationApplicationStatus, @evaluationApplicationSelectionStatus) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationAnswerNumber,userId,evaluationName,evaluationAooliation,evaluationAppli" +
                "cationDate,evaluationApplicationStatus,evaluationApplicationSelectionStatus";
            AddParameters(insertCommand, paraNames, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
            // 
            // Insert 를 호출한다
            EvaluationSelection entity = ((EvaluationSelection)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<EvaluationSelection> InsertAsync(int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = @"INSERT INTO EvaluationSelection(EvaluationAnswerNumber, UserId, EvaluationName, EvaluationAooliation, EvaluationApplicationDate, EvaluationApplicationStatus, EvaluationApplicationSelectionStatus) OUTPUT INSERTED.EvaluationSelectionNumber
VALUES (@evaluationAnswerNumber, @userId, @evaluationName, @evaluationAooliation, @evaluationApplicationDate, @evaluationApplicationStatus, @evaluationApplicationSelectionStatus) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationAnswerNumber,userId,evaluationName,evaluationAooliation,evaluationAppli" +
                "cationDate,evaluationApplicationStatus,evaluationApplicationSelectionStatus";
            AddParameters(insertCommand, paraNames, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
            // 
            // InsertAsync 를 호출한다
            EvaluationSelection entity = ((EvaluationSelection)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int evaluationSelectionNumber, int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = @"UPDATE EvaluationSelection SET EvaluationAnswerNumber = @evaluationAnswerNumber, UserId = @userId, EvaluationName = @evaluationName, EvaluationAooliation = @evaluationAooliation, EvaluationApplicationDate = @evaluationApplicationDate, EvaluationApplicationStatus = @evaluationApplicationStatus, EvaluationApplicationSelectionStatus = @evaluationApplicationSelectionStatus WHERE EvaluationSelectionNumber = @evaluationSelectionNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber,evaluationAnswerNumber,userId,evaluationName,evaluation" +
                "Aooliation,evaluationApplicationDate,evaluationApplicationStatus,evaluationAppli" +
                "cationSelectionStatus";
            AddParameters(updateCmd, paraNames, evaluationSelectionNumber, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
            // 
            // Update 를 호출한다
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int evaluationSelectionNumber, int evaluationAnswerNumber, string userId, string evaluationName, string evaluationAooliation, System.DateTime evaluationApplicationDate, string evaluationApplicationStatus, System.DateTime evaluationApplicationSelectionStatus)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = @"UPDATE EvaluationSelection SET EvaluationAnswerNumber = @evaluationAnswerNumber, UserId = @userId, EvaluationName = @evaluationName, EvaluationAooliation = @evaluationAooliation, EvaluationApplicationDate = @evaluationApplicationDate, EvaluationApplicationStatus = @evaluationApplicationStatus, EvaluationApplicationSelectionStatus = @evaluationApplicationSelectionStatus WHERE EvaluationSelectionNumber = @evaluationSelectionNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber,evaluationAnswerNumber,userId,evaluationName,evaluation" +
                "Aooliation,evaluationApplicationDate,evaluationApplicationStatus,evaluationAppli" +
                "cationSelectionStatus";
            AddParameters(updateCmd, paraNames, evaluationSelectionNumber, evaluationAnswerNumber, userId, evaluationName, evaluationAooliation, evaluationApplicationDate, evaluationApplicationStatus, evaluationApplicationSelectionStatus);
            // 
            // Update 를 호출한다
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSele" +
                "ctionNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(deleteCmd, paraNames, evaluationSelectionNumber);
            // 
            // Delete 를 호출한다
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int evaluationSelectionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM EvaluationSelection WHERE EvaluationSelectionNumber = @evaluationSele" +
                "ctionNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationSelectionNumber";
            AddParameters(deleteCmd, paraNames, evaluationSelectionNumber);
            // 
            // Delete 를 호출한다
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
    
    
    // Table('EvaluationSelection') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class EvaluationSelectionSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public EvaluationSelectionSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected EvaluationSelectionSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected EvaluationSelectionSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public EvaluationSelectionBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(EvaluationSelection);
        }
        
        private EvaluationSelectionBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private EvaluationSelectionBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((EvaluationSelectionBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(EvaluationSelectionBoundCollection))));
        }
        
        public partial class EvaluationSelectionBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new EvaluationSelection this[int index]
            {
                get
                {
                    return ((EvaluationSelection)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}
