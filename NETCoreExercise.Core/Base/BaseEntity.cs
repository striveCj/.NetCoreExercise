using System;

namespace NETCoreExercise.Core.Base
{
    public class BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Int64 Id { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddedDate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public string IpAddress { get; set; }

    }
}
