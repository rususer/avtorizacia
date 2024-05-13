using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtorizacia
{
    public partial class AnimationComponent : Component
    {
        #region [Поля класса]
        private Form _sourseForm;
        private FormAnimationEffect _closedEffect = FormAnimationEffect.ПОЯВЛЕНИЕ_ЗАТУХАНИЕ;
        private FormAnimationEffect _activateEffect = FormAnimationEffect.РАСКРЫТИЕ_СКРЫТИЕ;
        #endregion
        #region [Свойства класса]
        public FormAnimationEffect CloseEffect
        {
            get => _closedEffect;
            set => _activateEffect = value;
        }
        public FormAnimationEffect ActivateEffect
        {
            get => _closedEffect;
            set => _activateEffect = value;
        }
        public Control SourseForm
        {
            get => _sourseForm;
            set
            {
                if (value is Form)
                    _sourseForm = value as Form;
            }
        }
        #endregion

        public AnimationComponent()
        {
            InitializeComponent();
        }

        public AnimationComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #region [Методы]
        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, uint flags);

        public void ShowForm(int millisecond)
        {
            AnimateWindow(_sourseForm.Handle, millisecond, (uint)_activateEffect | 0x00020000);
            _sourseForm.Show();
        }

        public void CloseForm(int millisecond)
        {
            AnimateWindow(_sourseForm.Handle, millisecond, (uint)_activateEffect | 0x00010000);
            _sourseForm.Close();
        }
        #endregion
    }
}
