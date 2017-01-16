using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apparelbase.MVVMBase;
/*
 * MVVM에서는 property가 변하면 view에 자동으로 반영된다.
 * */

namespace WPFColorChange
{
    class WPFTest:ObservableObject //ViewModel의 기본이 되는 프로퍼티들이 정의되어 있다.
    {
        private int number;
        public int Number
        {
            get { return this.number; }
            set
            {
                if (this.number != value)
                {
                    this.number = value;
                    this.RaisePropertyChanged("Number"); //프로그램에게 변했다고 알려주는 메소드
                }
            }
        }
    }
}
