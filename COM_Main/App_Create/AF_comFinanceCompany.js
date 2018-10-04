<script type="text/javascript"> 
var script_comFinanceCompany = {
    validate_FinanceCompany: function(sender) {
      var Prefix = sender.id.replace('FinanceCompany','');
      this.validatePK_comFinanceCompany(sender,Prefix);
      },
    validatePK_comFinanceCompany: function(o,Prefix) {
      var value = o.id;
      try{$get(Prefix.replace('_F_','') + '_L_ErrMsgcomFinanceCompany').innerHTML = '';}catch(ex){}
      var FinanceCompany = $get(Prefix + 'FinanceCompany');
      if(FinanceCompany.value=='')
        return true;
      value = value + ',' + FinanceCompany.value ;
      o.style.backgroundImage  = 'url(../../images/pkloader.gif)';
      o.style.backgroundRepeat= 'no-repeat';
      o.style.backgroundPosition = 'right';
      PageMethods.validatePK_comFinanceCompany(value, this.validatedPK_comFinanceCompany);
    },
    validatedPK_comFinanceCompany: function(result) {
      var p = result.split('|');
      var o = $get(p[1]);
      o.style.backgroundImage  = 'none';
      if(p[0]=='1'){
        try{$get('cph1_FVcomFinanceCompany_L_ErrMsgcomFinanceCompany').innerHTML = p[2];}catch(ex){}
        o.value='';
        o.focus();
      }
    },
    temp: function() {
    }
    }
</script>
