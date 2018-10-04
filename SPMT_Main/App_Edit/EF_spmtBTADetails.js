<script type="text/javascript"> 
var script_spmtBTADetails = {
    ACEStatusID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('StatusID','');
      var F_StatusID = $get(sender._element.id);
      var F_StatusID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_StatusID.value = p[0];
      F_StatusID_Display.innerHTML = e.get_text();
    },
    ACEStatusID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('StatusID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACEStatusID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    ACECreatedBy_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('CreatedBy','');
      var F_CreatedBy = $get(sender._element.id);
      var F_CreatedBy_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_CreatedBy.value = p[0];
      F_CreatedBy_Display.innerHTML = e.get_text();
    },
    ACECreatedBy_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('CreatedBy','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACECreatedBy_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_StatusID: function(sender) {
      var Prefix = sender.id.replace('StatusID','');
      this.validated_FK_SPMT_BTADetails_StatusID_main = true;
      this.validate_FK_SPMT_BTADetails_StatusID(sender,Prefix);
      },
    validate_CreatedBy: function(sender) {
      var Prefix = sender.id.replace('CreatedBy','');
      this.validated_FK_SPMT_BTADetails_CreatedBy_main = true;
      this.validate_FK_SPMT_BTADetails_CreatedBy(sender,Prefix);
      },
    validate_FK_SPMT_BTADetails_CreatedBy: function(o,Prefix) {
      var value = o.id;
      var CreatedBy = $get(Prefix + 'CreatedBy');
      if(CreatedBy.value==''){
        if(this.validated_FK_SPMT_BTADetails_CreatedBy_main){
          var o_d = $get(Prefix + 'CreatedBy' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + CreatedBy.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_BTADetails_CreatedBy(value, this.validated_FK_SPMT_BTADetails_CreatedBy);
      },
    validated_FK_SPMT_BTADetails_CreatedBy_main: false,
    validated_FK_SPMT_BTADetails_CreatedBy: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtBTADetails.validated_FK_SPMT_BTADetails_CreatedBy_main){
        var o_d = $get(p[1]+'_Display');
        try{o_d.innerHTML = p[2];}catch(ex){}
      }
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        o.value='';
        o.focus();
      }
    },
    validate_FK_SPMT_BTADetails_StatusID: function(o,Prefix) {
      var value = o.id;
      var StatusID = $get(Prefix + 'StatusID');
      if(StatusID.value==''){
        if(this.validated_FK_SPMT_BTADetails_StatusID_main){
          var o_d = $get(Prefix + 'StatusID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + StatusID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SPMT_BTADetails_StatusID(value, this.validated_FK_SPMT_BTADetails_StatusID);
      },
    validated_FK_SPMT_BTADetails_StatusID_main: false,
    validated_FK_SPMT_BTADetails_StatusID: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_spmtBTADetails.validated_FK_SPMT_BTADetails_StatusID_main){
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
