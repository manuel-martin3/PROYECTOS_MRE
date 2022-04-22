//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace SGAC.BE
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(SE_USUARIO))]
    public partial class MA_CONTINENTE: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short cont_sContinenteId
        {
            get { return _cont_sContinenteId; }
            set
            {
                if (_cont_sContinenteId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'cont_sContinenteId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _cont_sContinenteId = value;
                    OnPropertyChanged("cont_sContinenteId");
                }
            }
        }
        private short _cont_sContinenteId;
    
        [DataMember]
        public string cont_vNombre
        {
            get { return _cont_vNombre; }
            set
            {
                if (_cont_vNombre != value)
                {
                    _cont_vNombre = value;
                    OnPropertyChanged("cont_vNombre");
                }
            }
        }
        private string _cont_vNombre;
    
        [DataMember]
        public string cont_cEstado
        {
            get { return _cont_cEstado; }
            set
            {
                if (_cont_cEstado != value)
                {
                    _cont_cEstado = value;
                    OnPropertyChanged("cont_cEstado");
                }
            }
        }
        private string _cont_cEstado;
    
        [DataMember]
        public short cont_sUsuarioCreacion
        {
            get { return _cont_sUsuarioCreacion; }
            set
            {
                if (_cont_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("cont_sUsuarioCreacion", _cont_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _cont_sUsuarioCreacion = value;
                    OnPropertyChanged("cont_sUsuarioCreacion");
                }
            }
        }
        private short _cont_sUsuarioCreacion;
    
        [DataMember]
        public string cont_vIPCreacion
        {
            get { return _cont_vIPCreacion; }
            set
            {
                if (_cont_vIPCreacion != value)
                {
                    _cont_vIPCreacion = value;
                    OnPropertyChanged("cont_vIPCreacion");
                }
            }
        }
        private string _cont_vIPCreacion;
    
        [DataMember]
        public System.DateTime cont_dFechaCreacion
        {
            get { return _cont_dFechaCreacion; }
            set
            {
                if (_cont_dFechaCreacion != value)
                {
                    _cont_dFechaCreacion = value;
                    OnPropertyChanged("cont_dFechaCreacion");
                }
            }
        }
        private System.DateTime _cont_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> cont_sUsuarioModificacion
        {
            get { return _cont_sUsuarioModificacion; }
            set
            {
                if (_cont_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("cont_sUsuarioModificacion", _cont_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _cont_sUsuarioModificacion = value;
                    OnPropertyChanged("cont_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _cont_sUsuarioModificacion;
    
        [DataMember]
        public string cont_vIPModificacion
        {
            get { return _cont_vIPModificacion; }
            set
            {
                if (_cont_vIPModificacion != value)
                {
                    _cont_vIPModificacion = value;
                    OnPropertyChanged("cont_vIPModificacion");
                }
            }
        }
        private string _cont_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> cont_dFechaModificacion
        {
            get { return _cont_dFechaModificacion; }
            set
            {
                if (_cont_dFechaModificacion != value)
                {
                    _cont_dFechaModificacion = value;
                    OnPropertyChanged("cont_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _cont_dFechaModificacion;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public SE_USUARIO SE_USUARIO
        {
            get { return _sE_USUARIO; }
            set
            {
                if (!ReferenceEquals(_sE_USUARIO, value))
                {
                    var previousValue = _sE_USUARIO;
                    _sE_USUARIO = value;
                    FixupSE_USUARIO(previousValue);
                    OnNavigationPropertyChanged("SE_USUARIO");
                }
            }
        }
        private SE_USUARIO _sE_USUARIO;
    
        [DataMember]
        public SE_USUARIO SE_USUARIO1
        {
            get { return _sE_USUARIO1; }
            set
            {
                if (!ReferenceEquals(_sE_USUARIO1, value))
                {
                    var previousValue = _sE_USUARIO1;
                    _sE_USUARIO1 = value;
                    FixupSE_USUARIO1(previousValue);
                    OnNavigationPropertyChanged("SE_USUARIO1");
                }
            }
        }
        private SE_USUARIO _sE_USUARIO1;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    
    
    
    
    		private Int16 _sOficinaConsularId;
    	[DataMember]
        public Int16 OficinaConsularId
        {
            get
            {
    			return _sOficinaConsularId;
    		}
    		set
    		{
    			_sOficinaConsularId = value;
    		}
    	}
    	private Int16 _sDiferenciaHoraria;
    	[DataMember]
        public Int16 DiferenciaHoraria
        {
            get
            {
    			return _sDiferenciaHoraria;
    		}
    		set
    		{
    			_sDiferenciaHoraria = value;
    		}
    	}
    	private Int16 _sHorarioVerano;
    	[DataMember]
        public Int16 HorarioVerano
        {
            get
            {
    			return _sHorarioVerano;
    		}
    		set
    		{
    			_sHorarioVerano = value;
    		}
    	}
    
    
    
    
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            SE_USUARIO = null;
            SE_USUARIO1 = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.MA_CONTINENTE.Contains(this))
            {
                previousValue.MA_CONTINENTE.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.MA_CONTINENTE.Contains(this))
                {
                    SE_USUARIO.MA_CONTINENTE.Add(this);
                }
    
                cont_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SE_USUARIO")
                    && (ChangeTracker.OriginalValues["SE_USUARIO"] == SE_USUARIO))
                {
                    ChangeTracker.OriginalValues.Remove("SE_USUARIO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SE_USUARIO", previousValue);
                }
                if (SE_USUARIO != null && !SE_USUARIO.ChangeTracker.ChangeTrackingEnabled)
                {
                    SE_USUARIO.StartTracking();
                }
            }
        }
    
        private void FixupSE_USUARIO1(SE_USUARIO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.MA_CONTINENTE1.Contains(this))
            {
                previousValue.MA_CONTINENTE1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.MA_CONTINENTE1.Contains(this))
                {
                    SE_USUARIO1.MA_CONTINENTE1.Add(this);
                }
    
                cont_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                cont_sUsuarioModificacion = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SE_USUARIO1")
                    && (ChangeTracker.OriginalValues["SE_USUARIO1"] == SE_USUARIO1))
                {
                    ChangeTracker.OriginalValues.Remove("SE_USUARIO1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SE_USUARIO1", previousValue);
                }
                if (SE_USUARIO1 != null && !SE_USUARIO1.ChangeTracker.ChangeTrackingEnabled)
                {
                    SE_USUARIO1.StartTracking();
                }
            }
        }

        #endregion
    }
}