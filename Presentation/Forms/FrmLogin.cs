﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using FitnessTracker.Desktop.Util;
using FitnessTracker.Desktop.Common;
using FitnessTracker.Desktop.Forms;
using FitnessTracker.Desktop.Domain.Models;
using FitnessTracker.Desktop.Identity;
using FitnessTracker.Desktop.Data.Usecase;
using FitnessTracker.Desktop.Data.Dto;
using FitnessTracker.Desktop.Presentation.Forms;

namespace FitnessTracker.Desktop
{
    public partial class FrmLogin : Form
    {
        private int _failCount = 0;
        private readonly int _failAttemptLimit = 5;
        private readonly UserUseCase _userUseCase;
        public FrmLogin(UserUseCase userUseCase)
        {
            _userUseCase = userUseCase;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }
        private void TryLogin()
        {
            var result = _userUseCase.Login(txtEmail.Text, txtPassword.Text);
            if (!result.Success)
            {
                _failCount++;
                var message = $"{result.Message} \n Fail attempt {_failCount}. \n App will be close after {_failAttemptLimit - _failCount}";
                CustomMessageBoxUtil.Error(message); return;
            }
            if (IsLoginAttemptExceedHandle()) return;
            UserIdentity.Instance.Init(result.Data);
            CheckUserProfile(result.Data);
            ShowDashBoard();
        }

        private void ShowDashBoard()
        {
            var dashBorad = App.MyServiceProvider.GetService<FrmUserDashBorad>();
            CommonUtil.ShowForm(dashBorad);
            dashBorad.Activate();
            this.Hide();
        }

        private void CheckUserProfile(UserDetail userDetail)
        {
            var profile = userDetail.Profile;
            if (profile is null)
            {
                CommonUtil.ShowDialogForm(App.MyServiceProvider.GetService<FrmUserProfile>());
            }
        }

        private bool IsLoginAttemptExceedHandle()
        {
            if (_failCount > _failAttemptLimit)
            {
                Application.Exit();
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e) => TryLogin();

        private void lblDontHaveAcount_Click(object sender, EventArgs e) => CommonUtil.ShowDialogForm(App.MyServiceProvider.GetService<FrmUserRegister>());
    }
}