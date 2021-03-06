﻿// <copyright file="TeamExplorerBaseNavigationItem.cs" company="http://shelvesetcomparer.codeplex.com">Copyright http://shelvesetcomparer.codeplex.com. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.</copyright>
namespace WiredTechSolutions.ShelvesetComparer
{
    using System;
    using System.Drawing;
    using Microsoft.TeamFoundation.Controls;
    
    /// <summary>
    /// Team Explorer base navigation item class.
    /// </summary>
    public class TeamExplorerBaseNavigationItem : TeamExplorerBase, ITeamExplorerNavigationItem2
    {
        private bool isVisible = true;
        private string text;
        private Image image;
        private object icon = null;
        private int argbColor;
        private bool isEnabled = true;

        public TeamExplorerBaseNavigationItem(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value; 
                this.RaisePropertyChanged("Text");
            }
        }

        public Image Image
        {
            get
            {
                return this.image;
            }

            set
            {
                this.image = value;
                this.RaisePropertyChanged("Image");
            }
        }

        public bool IsVisible
        {
            get
            {
                return this.isVisible;
            }

            set
            {
                this.isVisible = value;
                this.RaisePropertyChanged("IsVisible");
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                this.isEnabled = value;
                this.RaisePropertyChanged("IsEnabled");
            }
        }

        public int ArgbColor
        {
            get
            {
                return this.argbColor;
            }

            set
            {
                this.argbColor = value;
                this.RaisePropertyChanged("argbColor");
            }
        }

        public object Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                this.RaisePropertyChanged("Icon");
            }
        }

        public virtual void Invalidate()
        {
        }

        public virtual void Execute()
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}