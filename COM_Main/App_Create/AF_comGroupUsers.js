<script type="text/javascript"> 
var script_comGroupUsers = {
    ACELoginID_Selected: function(sender, e) {
      var Prefix = sender._element.id.replace('LoginID','');
      var F_LoginID = $get(sender._element.id);
      var F_LoginID_Display = $get(sender._element.id + '_Display');
      var retval = e.get_value();
      var p = retval.split('|');
      F_LoginID.value = p[0];
      F_LoginID_Display.innerHTML = e.get_text();
    },
    ACELoginID_Populating: function(sender,e) {
      var p = sender.get_element();
      var Prefix = sender._element.id.replace('LoginID','');
      p.style.backgroundImage  = 'url(../../images/loader.gif)';
      p.style.backgroundRepeat= 'no-repeat';
      p.style.backgroundPosition = 'right';
      sender._contextKey = '';
    },
    ACELoginID_Populated: function(sender,e) {
      var p = sender.get_element();
      p.style.backgroundImage  = 'none';
    },
    validate_GroupID: function(sender) {
      var Prefix = sender.id.replace('GroupID','');
      this.validated_FK_SYS_GroupLogins_SYS_Groups_main = true;
      this.validate_FK_SYS_GroupLogins_SYS_Groups(sender,Prefix);
      },
    validate_LoginID: function(sender) {
      var Prefix = sender.id.replace('LoginID','');
      this.validated_FK_SYS_GroupLogins_aspnet_Users_main = true;
      this.validate_FK_SYS_GroupLogins_aspnet_Users(sender,Prefix);
      },
    validate_FK_SYS_GroupLogins_aspnet_Users: function(o,Prefix) {
      var value = o.id;
      var LoginID = $get(Prefix + 'LoginID');
      if(LoginID.value==''){
        if(this.validated_FK_SYS_GroupLogins_aspnet_Users_main){
          var o_d = $get(Prefix + 'LoginID' + '_Display');
          try{o_d.innerHTML = '';}catch(ex){}
        }
        return true;
      }
      value = value + ',' + LoginID.value ;
        o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
        o.style.backgroundRepeat= 'no-repeat';
        o.style.backgroundPosition = 'right';
        PageMethods.validate_FK_SYS_GroupLogins_aspnet_Users(value, this.validated_FK_SYS_GroupLogins_aspnet_Users);
      },
    validated_FK_SYS_GroupLogins_aspnet_Users_main: false,
    validated_FK_SYS_GroupLogins_aspnet_Users: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      if(script_comGroupUsers.validated_FK_SYS_GroupLogins_aspnet_Users_main){
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
