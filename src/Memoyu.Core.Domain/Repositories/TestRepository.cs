﻿/**************************************************************************  
*   =================================
*   CLR版本  ：4.0.30319.42000
*   命名空间 ：Memoyu.Infrastructure.Repositories
*   文件名称 ：TestRepository.cs
*   =================================
*   创 建 者 ：Memoyu
*   创建日期 ：2021-01-03 8:29:23
*   邮箱     ：mmy6076@outlook.com
*   功能描述 ：
***************************************************************************/
using FreeSql;
using Memoyu.Core.Domain.Entities;
using Memoyu.Core.Domain.IRepositories;
using Memoyu.Core.Domain.Shared.Base.Impl;
using Memoyu.Core.Domain.Shared.Security;

namespace Memoyu.Core.Domain.Repositories
{
    public class TestRepository : AuditBaseRepository<TestEntity>, ITestRepository
    {
        private readonly ICurrentUser _currentUser;
        public TestRepository(UnitOfWorkManager unitOfWorkManager, ICurrentUser currentUser) : base(unitOfWorkManager, currentUser)
        {
            _currentUser = currentUser;
        }
    }
}