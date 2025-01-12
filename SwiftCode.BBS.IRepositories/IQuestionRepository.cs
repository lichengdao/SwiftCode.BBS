﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SwiftCode.BBS.IRepositories.BASE;
using SwiftCode.BBS.Model.Models;

namespace SwiftCode.BBS.IRepositories
{
    public interface IQuestionRepository : IBaseRepository<Question>
    {
        Task<Question> GetByIdAsync(int id, CancellationToken cancellationToken = default);

    }
}
