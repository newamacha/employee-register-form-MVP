﻿using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMVP.Views
{
    public interface IMainView
    {
        event EventHandler ShowEmployeeView;
        event EventHandler ShowDepartmentView;
    }
}
