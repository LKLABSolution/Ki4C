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
    
    
    // Table('EvaluationQuestion') Entity class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class EvaluationQuestion : SoftBand.EntityManager.Entity
    {
        
        public EvaluationQuestion()
        {
            this.DefineColumns(4);
        }
        
        public int EvaluationQuestionNumber
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
        
        public int AreaNumber
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
        
        public string EvaluationQuesttionCode
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
        
        public string EvaluationQuestionContents
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
        
        public static EvaluationQuestionService Service
        {
            get
            {
                return ((EvaluationQuestionService)(GetServiceObject(typeof(EvaluationQuestion), typeof(EvaluationQuestionService))));
            }
        }
        
        public static EvaluationQuestionSet GetAll()
        {
            return Service.GetAll();
        }
        
        public static string GetAllJson()
        {
            return Service.GetAllJson();
        }
        
        public static async Task<EvaluationQuestionSet> GetAllAsync()
        {
            return await Service.GetAllAsync();
        }
        
        public static async Task<string> GetAllJsonAsync()
        {
            return await Service.GetAllJsonAsync();
        }
        
        public static EvaluationQuestionSet GetForEvaluationAreaNumber(int areaNumber)
        {
            return Service.GetForEvaluationAreaNumber(areaNumber);
        }
        
        public static async Task<EvaluationQuestionSet> GetForEvaluationAreaNumberAsync(int areaNumber)
        {
            return await Service.GetForEvaluationAreaNumberAsync(areaNumber);
        }
        
        public static string GetForEvaluationAreaNumberJson(int areaNumber)
        {
            return Service.GetForEvaluationAreaNumberJson(areaNumber);
        }
        
        public static async Task<string> GetForEvaluationAreaNumberJsonAsync(int areaNumber)
        {
            return await Service.GetForEvaluationAreaNumberJsonAsync(areaNumber);
        }
        
        public static EvaluationQuestion GetByKey(int evaluationQuestionNumber)
        {
            return Service.GetByKey(evaluationQuestionNumber);
        }
        
        public static string GetByKeyJson(int evaluationQuestionNumber)
        {
            return Service.GetByKeyJson(evaluationQuestionNumber);
        }
        
        public static async Task<EvaluationQuestion> GetByKeyAsync(int evaluationQuestionNumber)
        {
            return await Service.GetByKeyAsync(evaluationQuestionNumber);
        }
        
        public static async Task<string> GetByKeyJsonAsync(int evaluationQuestionNumber)
        {
            return await Service.GetByKeyJsonAsync(evaluationQuestionNumber);
        }
        
        public static EvaluationQuestion Insert(int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Service.Insert(areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
        }
        
        public static async Task<EvaluationQuestion> InsertAsync(int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // InsertAsync 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await Service.InsertAsync(areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
        }
        
        public new EvaluationQuestion Insert()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return Insert(AreaNumber, EvaluationQuesttionCode, EvaluationQuestionContents);
        }
        
        public async Task<EvaluationQuestion> InsertAsync()
        {
            // Insert 명령은 Table Key가 자동 발생키로 구성되어 있지 않는 Table에 
            // 제한적으로 사용할 수 있습니다
            // 
            return await InsertAsync(AreaNumber, EvaluationQuesttionCode, EvaluationQuestionContents);
        }
        
        public new int Update()
        {
            // 인수를 해당 파라메타에 옮긴다
            int evaluationQuestionNumberParam = this.EvaluationQuestionNumber;
            int areaNumberParam = this.AreaNumber;
            string evaluationQuesttionCodeParam = this.EvaluationQuesttionCode;
            string evaluationQuestionContentsParam = this.EvaluationQuestionContents;
            // update 실행
            return Service.Update(evaluationQuestionNumberParam, areaNumberParam, evaluationQuesttionCodeParam, evaluationQuestionContentsParam);
        }
        
        public async Task<int> UpdateAsync()
        {
            // 인수를 해당 파라메타에 옮긴다
            int evaluationQuestionNumberParam = this.EvaluationQuestionNumber;
            int areaNumberParam = this.AreaNumber;
            string evaluationQuesttionCodeParam = this.EvaluationQuesttionCode;
            string evaluationQuestionContentsParam = this.EvaluationQuestionContents;
            return await Service.UpdateAsync(evaluationQuestionNumberParam, areaNumberParam, evaluationQuesttionCodeParam, evaluationQuestionContentsParam);
        }
        
        public static int Update(int evaluationQuestionNumber, int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            return Service.Update(evaluationQuestionNumber, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
        }
        
        public static async Task<int> UpdateAsync(int evaluationQuestionNumber, int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            return await Service.UpdateAsync(evaluationQuestionNumber, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
        }
        
        public static int Delete(int evaluationQuestionNumber)
        {
            return Service.Delete(evaluationQuestionNumber);
        }
        
        public static async Task<int> DeleteAsync(int evaluationQuestionNumber)
        {
            return await Service.DeleteAsync(evaluationQuestionNumber);
        }
        
        public new int Delete()
        {
            return Service.Delete(EvaluationQuestionNumber);
        }
        
        public async Task<int> DeleteAsync()
        {
            return await Service.DeleteAsync(EvaluationQuestionNumber);
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
    
    
    // Table('EvaluationQuestion')  Service class
    // Do not add or change code here.
    public partial class EvaluationQuestionService : SoftBand.EntityManager.Service
    {
        
        public EvaluationQuestionSet GetAll()
        {
            return ((EvaluationQuestionSet)(this.GetAll("EvaluationQuestion", typeof(EvaluationQuestionSet))));
        }
        
        public string GetAllJson()
        {
            return this.GetAllJson("EvaluationQuestion");
        }
        
        public async Task<EvaluationQuestionSet> GetAllAsync()
        {
            return ((EvaluationQuestionSet)(await this.GetAllAsync("EvaluationQuestion", typeof(EvaluationQuestionSet))));
        }
        
        public async Task<string> GetAllJsonAsync()
        {
            return await this.GetAllJsonAsync("EvaluationQuestion");
        }
        
        public EvaluationQuestionSet GetForEvaluationAreaNumber(int areaNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationQuestion] WHERE AreaNumber = @areaNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "areaNumber";
            AddParameters(selectCmd, paraNames, areaNumber);
            EvaluationQuestionSet entitySet = ((EvaluationQuestionSet)(this.GetEntitySet(selectCmd, typeof(EvaluationQuestionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public async Task<EvaluationQuestionSet> GetForEvaluationAreaNumberAsync(int areaNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationQuestion] WHERE AreaNumber = @areaNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "areaNumber";
            AddParameters(selectCmd, paraNames, areaNumber);
            EvaluationQuestionSet entitySet = ((EvaluationQuestionSet)(await this.GetEntitySetAsync(selectCmd, typeof(EvaluationQuestionSet))));
            selectCmd.Dispose();
            return entitySet;
        }
        
        public string GetForEvaluationAreaNumberJson(int areaNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationQuestion] WHERE AreaNumber = @areaNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "areaNumber";
            AddParameters(selectCmd, paraNames, areaNumber);
            return  this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<string> GetForEvaluationAreaNumberJsonAsync(int areaNumber)
        {
            // Sql Command Statement
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM [EvaluationQuestion] WHERE AreaNumber = @areaNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Make parameters
            string paraNames = "areaNumber";
            AddParameters(selectCmd, paraNames, areaNumber);
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public EvaluationQuestion GetByKey(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQues" +
                "tionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(selectCmd, paraNames, evaluationQuestionNumber);
            // 
            EvaluationQuestion entity = ((EvaluationQuestion)(this.GetEntity(selectCmd, typeof(EvaluationQuestionSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public  string GetByKeyJson(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQues" +
                "tionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(selectCmd, paraNames, evaluationQuestionNumber);
            // 
            return this.GetJsonDataSet(selectCmd);
        }
        
        public async Task<EvaluationQuestion> GetByKeyAsync(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQues" +
                "tionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(selectCmd, paraNames, evaluationQuestionNumber);
            // 
            // GetByKeyAsync 를 호출한다
            EvaluationQuestion entity = ((EvaluationQuestion)(await this.GetEntityAsync(selectCmd, typeof(EvaluationQuestionSet))));
            selectCmd.Dispose();
            return entity;
        }
        
        public async Task<string> GetByKeyJsonAsync(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand selectCmd = DbCommandFactory.CreateDbCommand();
            selectCmd.CommandText = "SELECT * FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQues" +
                "tionNumber";
            selectCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(selectCmd, paraNames, evaluationQuestionNumber);
            // 
            return await this.GetJsonDataSetAsync(selectCmd);
        }
        
        public EvaluationQuestion Insert(int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO EvaluationQuestion(AreaNumber, EvaluationQuesttionCode, EvaluationQue" +
                "stionContents) OUTPUT INSERTED.EvaluationQuestionNumber\r\nVALUES (@areaNumber, @e" +
                "valuationQuesttionCode, @evaluationQuestionContents) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "areaNumber,evaluationQuesttionCode,evaluationQuestionContents";
            AddParameters(insertCommand, paraNames, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
            // 
            // Insert 를 호출한다
            EvaluationQuestion entity = ((EvaluationQuestion)(this.GetByKey(System.Convert.ToInt32(this.ExecuteScalar(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public async Task<EvaluationQuestion> InsertAsync(int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand insertCommand = DbCommandFactory.CreateDbCommand();
            insertCommand.CommandText = "INSERT INTO EvaluationQuestion(AreaNumber, EvaluationQuesttionCode, EvaluationQue" +
                "stionContents) OUTPUT INSERTED.EvaluationQuestionNumber\r\nVALUES (@areaNumber, @e" +
                "valuationQuesttionCode, @evaluationQuestionContents) ";
            insertCommand.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "areaNumber,evaluationQuesttionCode,evaluationQuestionContents";
            AddParameters(insertCommand, paraNames, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
            // 
            // InsertAsync 를 호출한다
            EvaluationQuestion entity = ((EvaluationQuestion)(await this.GetByKeyAsync(System.Convert.ToInt32(await this.ExecuteScalarAsync(insertCommand)))));
            insertCommand.Dispose();
            return entity;
        }
        
        public int Update(int evaluationQuestionNumber, int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE EvaluationQuestion SET AreaNumber = @areaNumber, EvaluationQuesttionCode =" +
                " @evaluationQuesttionCode, EvaluationQuestionContents = @evaluationQuestionConte" +
                "nts WHERE EvaluationQuestionNumber = @evaluationQuestionNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber,areaNumber,evaluationQuesttionCode,evaluationQuestionCon" +
                "tents";
            AddParameters(updateCmd, paraNames, evaluationQuestionNumber, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
            // 
            // Update 를 호출한다
            int executeCnt = this.ExecuteNonQuery(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> UpdateAsync(int evaluationQuestionNumber, int areaNumber, string evaluationQuesttionCode, string evaluationQuestionContents)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand updateCmd = DbCommandFactory.CreateDbCommand();
            updateCmd.CommandText = "UPDATE EvaluationQuestion SET AreaNumber = @areaNumber, EvaluationQuesttionCode =" +
                " @evaluationQuesttionCode, EvaluationQuestionContents = @evaluationQuestionConte" +
                "nts WHERE EvaluationQuestionNumber = @evaluationQuestionNumber";
            updateCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber,areaNumber,evaluationQuesttionCode,evaluationQuestionCon" +
                "tents";
            AddParameters(updateCmd, paraNames, evaluationQuestionNumber, areaNumber, evaluationQuesttionCode, evaluationQuestionContents);
            // 
            // Update 를 호출한다
            int executeCnt = await this.ExecuteNonQueryAsync(updateCmd);
            updateCmd.Dispose();
            return executeCnt;
        }
        
        public int Delete(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQuesti" +
                "onNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(deleteCmd, paraNames, evaluationQuestionNumber);
            // 
            // Delete 를 호출한다
            int executeCnt = this.ExecuteNonQuery(deleteCmd);
            deleteCmd.Dispose();
            return executeCnt;
        }
        
        public async Task<int> DeleteAsync(int evaluationQuestionNumber)
        {
            // IDbCommand 명령문
            System.Data.IDbCommand deleteCmd = DbCommandFactory.CreateDbCommand();
            deleteCmd.CommandText = "DELETE FROM EvaluationQuestion WHERE EvaluationQuestionNumber = @evaluationQuesti" +
                "onNumber";
            deleteCmd.CommandType = System.Data.CommandType.Text;
            // 
            // Add parameter
            string paraNames = "evaluationQuestionNumber";
            AddParameters(deleteCmd, paraNames, evaluationQuestionNumber);
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
    
    
    // Table('EvaluationQuestion') EntitySet class
    // Do not add or change code here.
    [System.Serializable()]
    public partial class EvaluationQuestionSet : SoftBand.EntityManager.EntitySet, System.Collections.IEnumerable
    {
        
        // Constructor
        public EvaluationQuestionSet() : 
                this(null)
        {
        }
        
        // basic constructor
        protected EvaluationQuestionSet(object state)
        {
            this.Setup();
        }
        
        // remoting constructor...
        protected EvaluationQuestionSet(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : 
                base(info, context)
        {
            this.Setup();
        }
        
        public EvaluationQuestionBoundCollection Entities
        {
            get
            {
                return this.GetBoundCollection();
            }
        }
        
        // shared object initialization...
        private void Setup()
        {
            this.EntityType = typeof(EvaluationQuestion);
        }
        
        private EvaluationQuestionBoundCollection GetBoundCollection()
        {
            return this.GetBoundCollection(0);
        }
        
        private EvaluationQuestionBoundCollection GetBoundCollection(int tableIndex)
        {
            return ((EvaluationQuestionBoundCollection)(this.GetBoundCollection(this, tableIndex, typeof(EvaluationQuestionBoundCollection))));
        }
        
        public partial class EvaluationQuestionBoundCollection : SoftBand.EntityManager.EntityBoundCollection
        {
            
            public new EvaluationQuestion this[int index]
            {
                get
                {
                    return ((EvaluationQuestion)(this.EntitySet.GetEntity(this.TableIndex, index)));
                }
            }
        }
    }
}