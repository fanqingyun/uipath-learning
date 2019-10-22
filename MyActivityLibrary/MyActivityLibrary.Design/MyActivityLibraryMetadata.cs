using System;
using System.Activities.Presentation.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActivityLibrary.Design
{
    public sealed class MyActivityLibraryMetadata : IRegisterMetadata
    {
        #region Public Methods 

        /// <summary> 
        /// Registers metadata 
        /// </summary> 
        public static void RegisterAll()
        {
            var builder = new AttributeTableBuilder();
            MyActivityDesigner.RegisterMetadata(builder);

            // TODO: Other activities can be added here 
            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        /// <summary> 
        /// Registers metadata 
        /// </summary> 
        public void Register()
        {
            RegisterAll();
        }

        #endregion
    }
}
