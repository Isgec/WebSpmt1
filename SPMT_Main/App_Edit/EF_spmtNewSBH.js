<script type="text/javascript"> 
var script_spmtNewSBH = {
    ACEBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('BPID','');
      var F_BPID = $get(sender._element.id);
      var F_BPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_BPID.value = p[0];
      F_BPID_Display.innerHTML = e.get_text();
    },
    ACEBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('BPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACESupplierGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('SupplierGSTIN','');
      var F_SupplierGSTIN = $get(sender._element.id);
      var F_SupplierGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_SupplierGSTIN.value = p[1];
      F_SupplierGSTIN_Display.innerHTML = e.get_text();
    },
    ACESupplierGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('SupplierGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_BPID = $get(Prefix + 'BPID');
      sender._contextKey = F_BPID.value;
    },
    ACESupplierGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEProjectID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ProjectID','');
      var F_ProjectID = $get(sender._element.id);
      var F_ProjectID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ProjectID.value = p[0];
      F_ProjectID_Display.innerHTML = e.get_text();
    },
    ACEProjectID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ProjectID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEProjectID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEElementID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ElementID','');
      var F_ElementID = $get(sender._element.id);
      var F_ElementID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ElementID.value = p[0];
      F_ElementID_Display.innerHTML = e.get_text();
    },
    ACEElementID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ElementID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEElementID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEEmployeeID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('EmployeeID','');
      var F_EmployeeID = $get(sender._element.id);
      var F_EmployeeID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_EmployeeID.value = p[0];
      F_EmployeeID_Display.innerHTML = e.get_text();
    },
    ACEEmployeeID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('EmployeeID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEEmployeeID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_BPID: function(sender) {
      var Prefix = sender.id.replace('BPID','');
      this.validated_FK_SPMT_newSBH_BPID_main = true;
      this.validate_FK_SPMT_newSBH_BPID(sender,Prefix);
      },
    validate_SupplierGSTIN: function(sender) {
      var Prefix = sender.id.replace('SupplierGSTIN','');
      this.validated_FK_SPMT_newSBH_SupplierGSTIN_main = true;
      this.validate_FK_SPMT_newSBH_SupplierGSTIN(sender,Prefix);
      },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_newSBH_ProjectID_main = true;
      this.validate_FK_SPMT_newSBH_ProjectID(sender,Prefix);
      },
    validate_ElementID: function(sender) {
      var Prefix = sender.id.replace('ElementID','');
      this.validated_FK_SPMT_newSBH_ElementID_main = true;
      this.validate_FK_SPMT_newSBH_ElementID(sender,Prefix);
      },
    validate_EmployeeID: function(sender) {
      var Prefix = sender.id.replace('EmployeeID','');
      this.validated_FK_SPMT_newSBH_EmployeeID_main = true;
      this.validate_FK_SPMT_newSBH_EmployeeID(sender,Prefix);
      },
    validate_FK_SPMT_newSBH_EmployeeID: function(o,Prefix) {
      var value = o.id;
      var EmployeeID = $get(Prefix + 'EmployeeID');
      if(EmployeeID.value==''){
        if(this.validated_FK_SPMT_newSBH_EmployeeID_main){
          var o_d = $get(Prefix + 'EmployeeID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + EmployeeID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBH_EmployeeID(value, this.validated_FK_SPMT_newSBH_EmployeeID);
      },
    validated_FK_SPMT_newSBH_EmployeeID_main: false,
    validated_FK_SPMT_newSBH_EmployeeID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBH.validated_FK_SPMT_newSBH_EmployeeID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_newSBH_ProjectID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_newSBH_ProjectID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBH_ProjectID(value, this.validated_FK_SPMT_newSBH_ProjectID);
      },
    validated_FK_SPMT_newSBH_ProjectID_main: false,
    validated_FK_SPMT_newSBH_ProjectID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBH.validated_FK_SPMT_newSBH_ProjectID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_newSBH_ElementID: function(o,Prefix) {
      var value = o.id;
      var ElementID = $get(Prefix + 'ElementID');
      if(ElementID.value==''){
        if(this.validated_FK_SPMT_newSBH_ElementID_main){
          var o_d = $get(Prefix + 'ElementID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ElementID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBH_ElementID(value, this.validated_FK_SPMT_newSBH_ElementID);
      },
    validated_FK_SPMT_newSBH_ElementID_main: false,
    validated_FK_SPMT_newSBH_ElementID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBH.validated_FK_SPMT_newSBH_ElementID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_newSBH_SupplierGSTIN: function(o,Prefix) {
      var value = o.id;
      var BPID = $get(Prefix + 'BPID');
      if(BPID.value==''){
        if(this.validated_FK_SPMT_newSBH_SupplierGSTIN_main){
          var o_d = $get(Prefix + 'BPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BPID.value ;
      var SupplierGSTIN = $get(Prefix + 'SupplierGSTIN');
      if(SupplierGSTIN.value==''){
        if(this.validated_FK_SPMT_newSBH_SupplierGSTIN_main){
          var o_d = $get(Prefix + 'SupplierGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + SupplierGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBH_SupplierGSTIN(value, this.validated_FK_SPMT_newSBH_SupplierGSTIN);
      },
    validated_FK_SPMT_newSBH_SupplierGSTIN_main: false,
    validated_FK_SPMT_newSBH_SupplierGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBH.validated_FK_SPMT_newSBH_SupplierGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_newSBH_BPID: function(o,Prefix) {
      var value = o.id;
      var BPID = $get(Prefix + 'BPID');
      if(BPID.value==''){
        if(this.validated_FK_SPMT_newSBH_BPID_main){
          var o_d = $get(Prefix + 'BPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + BPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_newSBH_BPID(value, this.validated_FK_SPMT_newSBH_BPID);
      },
    validated_FK_SPMT_newSBH_BPID_main: false,
    validated_FK_SPMT_newSBH_BPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtNewSBH.validated_FK_SPMT_newSBH_BPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
