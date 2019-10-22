using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Activities;
using System.ComponentModel;

namespace MyActivityLibrary
{
    public sealed class MyActivity : NativeActivity<string>
    {
        #region Public Properties 

        /// <summary> 
        /// Gets or sets Option. 
        /// </summary> 
        public MyEnum Option { get; set; }

        /// <summary> 
        /// Gets or sets a value indicating whether TestCode. 
        /// </summary> 
        public bool TestCode { get; set; }

        /// <summary> 
        /// Gets or sets Text. 
        /// </summary> 
        [DefaultValue(null)]
        public InArgument<string> Text { get; set; }

        #endregion

        #region Methods 

        /// <summary> 
        /// The execute. 
        /// </summary> 
        /// <param name="context"> 
        /// The context. 
        /// </param> 
        protected override void Execute(NativeActivityContext context)
        {
            this.Result.Set(
                context,
                string.Format(
                    "Text is {0}, TestCode is {1}, Option is {2}",
                    context.GetValue(this.Text),
                    this.TestCode,
                    this.Option));
        }

        #endregion
    }
}
