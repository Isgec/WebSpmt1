<script type="text/javascript"> 
var script_spmtDCHeader = {
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
    ACEConsignerBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      var F_ConsignerBPID = $get(sender._element.id);
      var F_ConsignerBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerBPID.value = p[0];
      F_ConsignerBPID_Display.innerHTML = e.get_text();
    },
    ACEConsignerBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConsignerBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsigneeBPID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsigneeBPID','');
      var F_ConsigneeBPID = $get(sender._element.id);
      var F_ConsigneeBPID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsigneeBPID.value = p[0];
      F_ConsigneeBPID_Display.innerHTML = e.get_text();
    },
    ACEConsigneeBPID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsigneeBPID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEConsigneeBPID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsignerGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      var F_ConsignerGSTIN = $get(sender._element.id);
      var F_ConsignerGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsignerGSTIN.value = p[1];
      F_ConsignerGSTIN_Display.innerHTML = e.get_text();
    },
    ACEConsignerGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsignerGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      sender._contextKey = F_ConsignerBPID.value;
    },
    ACEConsignerGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACEConsigneeGSTIN_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('ConsigneeGSTIN','');
      var F_ConsigneeGSTIN = $get(sender._element.id);
      var F_ConsigneeGSTIN_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_ConsigneeGSTIN.value = p[1];
      F_ConsigneeGSTIN_Display.innerHTML = e.get_text();
    },
    ACEConsigneeGSTIN_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('ConsigneeGSTIN','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
      var F_ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      sender._contextKey = F_ConsigneeBPID.value;
    },
    ACEConsigneeGSTIN_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACETransporterID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('TransporterID','');
      var F_TransporterID = $get(sender._element.id);
      var F_TransporterID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_TransporterID.value = p[0];
      F_TransporterID_Display.innerHTML = e.get_text();
    },
    ACETransporterID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('TransporterID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACETransporterID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_ProjectID: function(sender) {
      var Prefix = sender.id.replace('ProjectID','');
      this.validated_FK_SPMT_DCHeader_ProjectID_main = true;
      this.validate_FK_SPMT_DCHeader_ProjectID(sender,Prefix);
      },
    validate_ConsignerBPID: function(sender) {
      var Prefix = sender.id.replace('ConsignerBPID','');
      this.validated_FK_SPMT_DCHeader_ConsignerBPID_main = true;
      this.validate_FK_SPMT_DCHeader_ConsignerBPID(sender,Prefix);
      },
    validate_ConsigneeBPID: function(sender) {
      var Prefix = sender.id.replace('ConsigneeBPID','');
      this.validated_FK_SPMT_DCHeader_ConsigneeBPID_main = true;
      this.validate_FK_SPMT_DCHeader_ConsigneeBPID(sender,Prefix);
      },
    validate_ConsignerGSTIN: function(sender) {
      var Prefix = sender.id.replace('ConsignerGSTIN','');
      this.validated_FK_SPMT_DCHeader_ConsignerGSTIN_main = true;
      this.validate_FK_SPMT_DCHeader_ConsignerGSTIN(sender,Prefix);
      },
    validate_ConsigneeGSTIN: function(sender) {
      var Prefix = sender.id.replace('ConsigneeGSTIN','');
      this.validated_FK_SPMT_DCHeader_ConsigneeGISTIN_main = true;
      this.validate_FK_SPMT_DCHeader_ConsigneeGISTIN(sender,Prefix);
      },
    validate_TransporterID: function(sender) {
      var Prefix = sender.id.replace('TransporterID','');
      this.validated_FK_SPMT_DCHeader_TransporterID_main = true;
      this.validate_FK_SPMT_DCHeader_TransporterID(sender,Prefix);
      },
    validate_FK_SPMT_DCHeader_ProjectID: function(o,Prefix) {
      var value = o.id;
      var ProjectID = $get(Prefix + 'ProjectID');
      if(ProjectID.value==''){
        if(this.validated_FK_SPMT_DCHeader_ProjectID_main){
          var o_d = $get(Prefix + 'ProjectID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ProjectID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_ProjectID(value, this.validated_FK_SPMT_DCHeader_ProjectID);
      },
    validated_FK_SPMT_DCHeader_ProjectID_main: false,
    validated_FK_SPMT_DCHeader_ProjectID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_ProjectID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_DCHeader_ConsignerGSTIN: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
      var ConsignerGSTIN = $get(Prefix + 'ConsignerGSTIN');
      if(ConsignerGSTIN.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsignerGSTIN_main){
          var o_d = $get(Prefix + 'ConsignerGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_ConsignerGSTIN(value, this.validated_FK_SPMT_DCHeader_ConsignerGSTIN);
      },
    validated_FK_SPMT_DCHeader_ConsignerGSTIN_main: false,
    validated_FK_SPMT_DCHeader_ConsignerGSTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_ConsignerGSTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_DCHeader_ConsigneeGISTIN: function(o,Prefix) {
      var value = o.id;
      var ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      if(ConsigneeBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsigneeGISTIN_main){
          var o_d = $get(Prefix + 'ConsigneeBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeBPID.value ;
      var ConsigneeGSTIN = $get(Prefix + 'ConsigneeGSTIN');
      if(ConsigneeGSTIN.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsigneeGISTIN_main){
          var o_d = $get(Prefix + 'ConsigneeGSTIN' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeGSTIN.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_ConsigneeGISTIN(value, this.validated_FK_SPMT_DCHeader_ConsigneeGISTIN);
      },
    validated_FK_SPMT_DCHeader_ConsigneeGISTIN_main: false,
    validated_FK_SPMT_DCHeader_ConsigneeGISTIN: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_ConsigneeGISTIN_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_DCHeader_ConsignerBPID: function(o,Prefix) {
      var value = o.id;
      var ConsignerBPID = $get(Prefix + 'ConsignerBPID');
      if(ConsignerBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsignerBPID_main){
          var o_d = $get(Prefix + 'ConsignerBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsignerBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_ConsignerBPID(value, this.validated_FK_SPMT_DCHeader_ConsignerBPID);
      },
    validated_FK_SPMT_DCHeader_ConsignerBPID_main: false,
    validated_FK_SPMT_DCHeader_ConsignerBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_ConsignerBPID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_DCHeader_TransporterID: function(o,Prefix) {
      var value = o.id;
      var TransporterID = $get(Prefix + 'TransporterID');
      if(TransporterID.value==''){
        if(this.validated_FK_SPMT_DCHeader_TransporterID_main){
          var o_d = $get(Prefix + 'TransporterID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + TransporterID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_TransporterID(value, this.validated_FK_SPMT_DCHeader_TransporterID);
      },
    validated_FK_SPMT_DCHeader_TransporterID_main: false,
    validated_FK_SPMT_DCHeader_TransporterID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_TransporterID_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_DCHeader_ConsigneeBPID: function(o,Prefix) {
      var value = o.id;
      var ConsigneeBPID = $get(Prefix + 'ConsigneeBPID');
      if(ConsigneeBPID.value==''){
        if(this.validated_FK_SPMT_DCHeader_ConsigneeBPID_main){
          var o_d = $get(Prefix + 'ConsigneeBPID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + ConsigneeBPID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_DCHeader_ConsigneeBPID(value, this.validated_FK_SPMT_DCHeader_ConsigneeBPID);
      },
    validated_FK_SPMT_DCHeader_ConsigneeBPID_main: false,
    validated_FK_SPMT_DCHeader_ConsigneeBPID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtDCHeader.validated_FK_SPMT_DCHeader_ConsigneeBPID_main){
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
