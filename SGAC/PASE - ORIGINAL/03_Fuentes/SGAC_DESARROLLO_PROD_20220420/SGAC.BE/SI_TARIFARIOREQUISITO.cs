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
    [KnownType(typeof(SI_PARAMETRO))]
    [KnownType(typeof(SI_TARIFARIO))]
    [KnownType(typeof(MA_REQUISITO_ACTUACION))]
    public partial class SI_TARIFARIOREQUISITO: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public short tare_sTarifarioRequisitoId
        {
            get { return _tare_sTarifarioRequisitoId; }
            set
            {
                if (_tare_sTarifarioRequisitoId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'tare_sTarifarioRequisitoId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _tare_sTarifarioRequisitoId = value;
                    OnPropertyChanged("tare_sTarifarioRequisitoId");
                }
            }
        }
        private short _tare_sTarifarioRequisitoId;
    
        [DataMember]
        public short tare_sTarifarioId
        {
            get { return _tare_sTarifarioId; }
            set
            {
                if (_tare_sTarifarioId != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sTarifarioId", _tare_sTarifarioId);
                    if (!IsDeserializing)
                    {
                        if (SI_TARIFARIO != null && SI_TARIFARIO.tari_sTarifarioId != value)
                        {
                            SI_TARIFARIO = null;
                        }
                    }
                    _tare_sTarifarioId = value;
                    OnPropertyChanged("tare_sTarifarioId");
                }
            }
        }
        private short _tare_sTarifarioId;
    
        [DataMember]
        public short tare_sRequisitoId
        {
            get { return _tare_sRequisitoId; }
            set
            {
                if (_tare_sRequisitoId != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sRequisitoId", _tare_sRequisitoId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO1 != null && SI_PARAMETRO1.para_sParametroId != value)
                        {
                            SI_PARAMETRO1 = null;
                        }
                        if (MA_REQUISITO_ACTUACION != null && MA_REQUISITO_ACTUACION.reac_sRequisitoId != value)
                        {
                            MA_REQUISITO_ACTUACION = null;
                        }
                    }
                    _tare_sRequisitoId = value;
                    OnPropertyChanged("tare_sRequisitoId");
                }
            }
        }
        private short _tare_sRequisitoId;
    
        [DataMember]
        public Nullable<short> tare_sTipoActaId
        {
            get { return _tare_sTipoActaId; }
            set
            {
                if (_tare_sTipoActaId != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sTipoActaId", _tare_sTipoActaId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO2 != null && SI_PARAMETRO2.para_sParametroId != value)
                        {
                            SI_PARAMETRO2 = null;
                        }
                    }
                    _tare_sTipoActaId = value;
                    OnPropertyChanged("tare_sTipoActaId");
                }
            }
        }
        private Nullable<short> _tare_sTipoActaId;
    
        [DataMember]
        public Nullable<short> tare_sCondicionId
        {
            get { return _tare_sCondicionId; }
            set
            {
                if (_tare_sCondicionId != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sCondicionId", _tare_sCondicionId);
                    if (!IsDeserializing)
                    {
                        if (SI_PARAMETRO != null && SI_PARAMETRO.para_sParametroId != value)
                        {
                            SI_PARAMETRO = null;
                        }
                    }
                    _tare_sCondicionId = value;
                    OnPropertyChanged("tare_sCondicionId");
                }
            }
        }
        private Nullable<short> _tare_sCondicionId;
    
        [DataMember]
        public string tare_cEstado
        {
            get { return _tare_cEstado; }
            set
            {
                if (_tare_cEstado != value)
                {
                    _tare_cEstado = value;
                    OnPropertyChanged("tare_cEstado");
                }
            }
        }
        private string _tare_cEstado;
    
        [DataMember]
        public short tare_sUsuarioCreacion
        {
            get { return _tare_sUsuarioCreacion; }
            set
            {
                if (_tare_sUsuarioCreacion != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sUsuarioCreacion", _tare_sUsuarioCreacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO != null && SE_USUARIO.usua_sUsuarioId != value)
                        {
                            SE_USUARIO = null;
                        }
                    }
                    _tare_sUsuarioCreacion = value;
                    OnPropertyChanged("tare_sUsuarioCreacion");
                }
            }
        }
        private short _tare_sUsuarioCreacion;
    
        [DataMember]
        public string tare_vIPCreacion
        {
            get { return _tare_vIPCreacion; }
            set
            {
                if (_tare_vIPCreacion != value)
                {
                    _tare_vIPCreacion = value;
                    OnPropertyChanged("tare_vIPCreacion");
                }
            }
        }
        private string _tare_vIPCreacion;
    
        [DataMember]
        public System.DateTime tare_dFechaCreacion
        {
            get { return _tare_dFechaCreacion; }
            set
            {
                if (_tare_dFechaCreacion != value)
                {
                    _tare_dFechaCreacion = value;
                    OnPropertyChanged("tare_dFechaCreacion");
                }
            }
        }
        private System.DateTime _tare_dFechaCreacion;
    
        [DataMember]
        public Nullable<short> tare_sUsuarioModificacion
        {
            get { return _tare_sUsuarioModificacion; }
            set
            {
                if (_tare_sUsuarioModificacion != value)
                {
                    ChangeTracker.RecordOriginalValue("tare_sUsuarioModificacion", _tare_sUsuarioModificacion);
                    if (!IsDeserializing)
                    {
                        if (SE_USUARIO1 != null && SE_USUARIO1.usua_sUsuarioId != value)
                        {
                            SE_USUARIO1 = null;
                        }
                    }
                    _tare_sUsuarioModificacion = value;
                    OnPropertyChanged("tare_sUsuarioModificacion");
                }
            }
        }
        private Nullable<short> _tare_sUsuarioModificacion;
    
        [DataMember]
        public string tare_vIPModificacion
        {
            get { return _tare_vIPModificacion; }
            set
            {
                if (_tare_vIPModificacion != value)
                {
                    _tare_vIPModificacion = value;
                    OnPropertyChanged("tare_vIPModificacion");
                }
            }
        }
        private string _tare_vIPModificacion;
    
        [DataMember]
        public Nullable<System.DateTime> tare_dFechaModificacion
        {
            get { return _tare_dFechaModificacion; }
            set
            {
                if (_tare_dFechaModificacion != value)
                {
                    _tare_dFechaModificacion = value;
                    OnPropertyChanged("tare_dFechaModificacion");
                }
            }
        }
        private Nullable<System.DateTime> _tare_dFechaModificacion;

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
    
        [DataMember]
        public SI_PARAMETRO SI_PARAMETRO
        {
            get { return _sI_PARAMETRO; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO, value))
                {
                    var previousValue = _sI_PARAMETRO;
                    _sI_PARAMETRO = value;
                    FixupSI_PARAMETRO(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO;
    
        [DataMember]
        public SI_PARAMETRO SI_PARAMETRO1
        {
            get { return _sI_PARAMETRO1; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO1, value))
                {
                    var previousValue = _sI_PARAMETRO1;
                    _sI_PARAMETRO1 = value;
                    FixupSI_PARAMETRO1(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO1");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO1;
    
        [DataMember]
        public SI_PARAMETRO SI_PARAMETRO2
        {
            get { return _sI_PARAMETRO2; }
            set
            {
                if (!ReferenceEquals(_sI_PARAMETRO2, value))
                {
                    var previousValue = _sI_PARAMETRO2;
                    _sI_PARAMETRO2 = value;
                    FixupSI_PARAMETRO2(previousValue);
                    OnNavigationPropertyChanged("SI_PARAMETRO2");
                }
            }
        }
        private SI_PARAMETRO _sI_PARAMETRO2;
    
        [DataMember]
        public SI_TARIFARIO SI_TARIFARIO
        {
            get { return _sI_TARIFARIO; }
            set
            {
                if (!ReferenceEquals(_sI_TARIFARIO, value))
                {
                    var previousValue = _sI_TARIFARIO;
                    _sI_TARIFARIO = value;
                    FixupSI_TARIFARIO(previousValue);
                    OnNavigationPropertyChanged("SI_TARIFARIO");
                }
            }
        }
        private SI_TARIFARIO _sI_TARIFARIO;
    
        [DataMember]
        public MA_REQUISITO_ACTUACION MA_REQUISITO_ACTUACION
        {
            get { return _mA_REQUISITO_ACTUACION; }
            set
            {
                if (!ReferenceEquals(_mA_REQUISITO_ACTUACION, value))
                {
                    var previousValue = _mA_REQUISITO_ACTUACION;
                    _mA_REQUISITO_ACTUACION = value;
                    FixupMA_REQUISITO_ACTUACION(previousValue);
                    OnNavigationPropertyChanged("MA_REQUISITO_ACTUACION");
                }
            }
        }
        private MA_REQUISITO_ACTUACION _mA_REQUISITO_ACTUACION;

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
            SI_PARAMETRO = null;
            SI_PARAMETRO1 = null;
            SI_PARAMETRO2 = null;
            SI_TARIFARIO = null;
            MA_REQUISITO_ACTUACION = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupSE_USUARIO(SE_USUARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO.Remove(this);
            }
    
            if (SE_USUARIO != null)
            {
                if (!SE_USUARIO.SI_TARIFARIOREQUISITO.Contains(this))
                {
                    SE_USUARIO.SI_TARIFARIOREQUISITO.Add(this);
                }
    
                tare_sUsuarioCreacion = SE_USUARIO.usua_sUsuarioId;
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
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO1.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO1.Remove(this);
            }
    
            if (SE_USUARIO1 != null)
            {
                if (!SE_USUARIO1.SI_TARIFARIOREQUISITO1.Contains(this))
                {
                    SE_USUARIO1.SI_TARIFARIOREQUISITO1.Add(this);
                }
    
                tare_sUsuarioModificacion = SE_USUARIO1.usua_sUsuarioId;
            }
            else if (!skipKeys)
            {
                tare_sUsuarioModificacion = null;
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
    
        private void FixupSI_PARAMETRO(SI_PARAMETRO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO.Remove(this);
            }
    
            if (SI_PARAMETRO != null)
            {
                if (!SI_PARAMETRO.SI_TARIFARIOREQUISITO.Contains(this))
                {
                    SI_PARAMETRO.SI_TARIFARIOREQUISITO.Add(this);
                }
    
                tare_sCondicionId = SI_PARAMETRO.para_sParametroId;
            }
            else if (!skipKeys)
            {
                tare_sCondicionId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO"] == SI_PARAMETRO))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO", previousValue);
                }
                if (SI_PARAMETRO != null && !SI_PARAMETRO.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO.StartTracking();
                }
            }
        }
    
        private void FixupSI_PARAMETRO1(SI_PARAMETRO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO1.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO1.Remove(this);
            }
    
            if (SI_PARAMETRO1 != null)
            {
                if (!SI_PARAMETRO1.SI_TARIFARIOREQUISITO1.Contains(this))
                {
                    SI_PARAMETRO1.SI_TARIFARIOREQUISITO1.Add(this);
                }
    
                tare_sRequisitoId = SI_PARAMETRO1.para_sParametroId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO1")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO1"] == SI_PARAMETRO1))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO1");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO1", previousValue);
                }
                if (SI_PARAMETRO1 != null && !SI_PARAMETRO1.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO1.StartTracking();
                }
            }
        }
    
        private void FixupSI_PARAMETRO2(SI_PARAMETRO previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO2.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO2.Remove(this);
            }
    
            if (SI_PARAMETRO2 != null)
            {
                if (!SI_PARAMETRO2.SI_TARIFARIOREQUISITO2.Contains(this))
                {
                    SI_PARAMETRO2.SI_TARIFARIOREQUISITO2.Add(this);
                }
    
                tare_sTipoActaId = SI_PARAMETRO2.para_sParametroId;
            }
            else if (!skipKeys)
            {
                tare_sTipoActaId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_PARAMETRO2")
                    && (ChangeTracker.OriginalValues["SI_PARAMETRO2"] == SI_PARAMETRO2))
                {
                    ChangeTracker.OriginalValues.Remove("SI_PARAMETRO2");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_PARAMETRO2", previousValue);
                }
                if (SI_PARAMETRO2 != null && !SI_PARAMETRO2.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_PARAMETRO2.StartTracking();
                }
            }
        }
    
        private void FixupSI_TARIFARIO(SI_TARIFARIO previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO.Remove(this);
            }
    
            if (SI_TARIFARIO != null)
            {
                if (!SI_TARIFARIO.SI_TARIFARIOREQUISITO.Contains(this))
                {
                    SI_TARIFARIO.SI_TARIFARIOREQUISITO.Add(this);
                }
    
                tare_sTarifarioId = SI_TARIFARIO.tari_sTarifarioId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("SI_TARIFARIO")
                    && (ChangeTracker.OriginalValues["SI_TARIFARIO"] == SI_TARIFARIO))
                {
                    ChangeTracker.OriginalValues.Remove("SI_TARIFARIO");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("SI_TARIFARIO", previousValue);
                }
                if (SI_TARIFARIO != null && !SI_TARIFARIO.ChangeTracker.ChangeTrackingEnabled)
                {
                    SI_TARIFARIO.StartTracking();
                }
            }
        }
    
        private void FixupMA_REQUISITO_ACTUACION(MA_REQUISITO_ACTUACION previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.SI_TARIFARIOREQUISITO.Contains(this))
            {
                previousValue.SI_TARIFARIOREQUISITO.Remove(this);
            }
    
            if (MA_REQUISITO_ACTUACION != null)
            {
                if (!MA_REQUISITO_ACTUACION.SI_TARIFARIOREQUISITO.Contains(this))
                {
                    MA_REQUISITO_ACTUACION.SI_TARIFARIOREQUISITO.Add(this);
                }
    
                tare_sRequisitoId = MA_REQUISITO_ACTUACION.reac_sRequisitoId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("MA_REQUISITO_ACTUACION")
                    && (ChangeTracker.OriginalValues["MA_REQUISITO_ACTUACION"] == MA_REQUISITO_ACTUACION))
                {
                    ChangeTracker.OriginalValues.Remove("MA_REQUISITO_ACTUACION");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("MA_REQUISITO_ACTUACION", previousValue);
                }
                if (MA_REQUISITO_ACTUACION != null && !MA_REQUISITO_ACTUACION.ChangeTracker.ChangeTrackingEnabled)
                {
                    MA_REQUISITO_ACTUACION.StartTracking();
                }
            }
        }

        #endregion
    }
}
