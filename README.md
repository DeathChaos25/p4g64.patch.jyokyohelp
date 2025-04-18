# Custom In-Combat Skill Effect Text for P4G (64-bit Steam version)  
  
Allows for mods to have a custom effect description when using certain skills in combat (such as stat up skills), also supports removing messages from existing skills.  

Effect messages are taken from the BMD file embedded inside the MSG.TBL file that is found inside the init_free.bin file.  


# How to Use
Add this mod as a dependency to your mod of choice  
Inside your mod, add a folder named "skill"  
Inside this "skill" folder, create a txt file named "datJyokyoHelp.txt"


Then, inside the txt file, format the data the following way:  

skillID | messageID
  
Example:  
221 | 202  

The given example would make the Masukukaja skill (skill ID 221) no longer show the "Hit/Evasion rate up!" message, and instead will now show "Shadow Yukiko has a passionate stare..." as the effect message (message id 202).  

![sample](https://i.imgur.com/pcyHurB.png)  

  
Note that you can have multiple lines in the txt file to patch multiple skills at once, just make sure all lines follow the proper formatting.  

# Documentation

For a list of Skill IDs, [please refer to the Amicitia Wiki's page for P4G Skills](https://amicitia.miraheze.org/wiki/Persona_4_Golden/Skills).  

For a list of messages and their message ID, while they can be found by dumping the BMD file embedded in MSG.TBL, they will be listed below for convenience:  
| ID | Name | Message |
|----|------|---------|
| 0 | jyokyohelp_NONE | (using a value of 0 will display no message) |
| 1 | jyokyohelp_AVOID_ENEMY | Attack dodged! |
| 2 | jyokyohelp_ESCAPE_PLAYER | this is a bug 04. |
| 3 | jyokyohelp_ESCAPE_ENEMY | [var 0] ran away... |
| 4 | jyokyohelp_BAD_ATTACK_PL | [var 0] turned against the party! |
| 5 | jyokyohelp_BAD_ATTACK_EN | [var 0] attacked its allies! |
| 6 | jyokyohelp_CONFUSE_PLAYE | [var 0] is panicked! |
| 7 | jyokyohelp_CONFUSE_ENEMY | [var 0] is panicked! |
| 8 | jyokyohelp_KYOUHU_ESCAPE | [var 0] withdrew from battle! |
| 9 | jyokyohelp_KYOUHU_ESCAPE_2 |[var 0]  ran away! |
| 10 | jyokyohelp_KYOUHU_WAIT_P | [var 0] is paralyzed with fear! |
| 11 | jyokyohelp_KYOUHU_WAIT_E | [var 0] is paralyzed with fear! |
| 12 | jyokyohelp_GEKIKOU_ATTAC | [var 0] is enraged! |
| 13 | jyokyohelp_GEKIKOU_ATTAC_2 | [var 0] is enraged! |
| 14 | jyokyohelp_ROUKA_SET_PLA | Inflicted with enervation... |
| 15 | jyokyohelp_ROUKA_SET_ENE | The foe is enervated! |
| 16 | jyokyohelp_DOKU_HATUDOU_ | Inflicted with poison... |
| 17 | jyokyohelp_DOKU_HATUDOU__2 | The foe is poisoned! |
| 18 | jyokyohelp_KONRAN_HATUDO | Inflicted with panic... |
| 19 | jyokyohelp_KONRAN_HATUDO_2 | The foe is panicked! |
| 20 | jyokyohelp_KYOUFU_HATUDO | Inflicted with fear... |
| 21 | jyokyohelp_KYOUFU_HATUDO_2 | The foe is afraid! |
| 22 | jyokyohelp_GEKIKOU_HATUD | Inflicted with rage... |
| 23 | jyokyohelp_GEKIKOU_HATUD_2 | The foe is enraged! |
| 24 | jyokyohelp_KIZETU_HATUDO | This person is dizzy... |
| 25 | jyokyohelp_KIZETU_HATUDO_2 | The foe is dizzy! |
| 26 | jyokyohelp_SUIJYAKU_HATU | Inflicted with exhaustion... |
| 27 | jyokyohelp_SUIJYAKU_HATU_2 | The foe is exhausted! |
| 28 | jyokyohelp_MAFU_HATUDOU_ | Inflicted with silence... |
| 29 | jyokyohelp_MAFU_HATUDOU__2 | The foe is silenced! |
| 30 | jyokyohelp_BATK_MATK_RES | Attack reverted! |
| 31 | jyokyohelp_BATK_MATK_RES_2 | Attack reverted! |
| 32 | jyokyohelp_HIT_ESC_RESET | Hit/Evasion rate reverted! |
| 33 | jyokyohelp_HIT_ESC_RESET_2 | Hit/Evasion rate reverted! |
| 34 | jyokyohelp_DEF_RESET_PLA | Defense reverted! |
| 35 | jyokyohelp_DEF_RESET_ENE | Defense reverted! |
| 36 | jyokyohelp_HIRISK_RESET_ | Critical Rate reverted! |
| 37 | jyokyohelp_HIRISK_RESET__2 | Critical Rate reverted! |
| 38 | jyokyohelp_RISKHG_RESET_ | Critical Rate reverted! |
| 39 | jyokyohelp_RISKHG_RESET__2 | Critical Rate reverted! |
| 40 | jyokyohelp_BADx2_RESET_P | Ailment Susceptibility reverted! |
| 41 | jyokyohelp_BADx2_RESET_E | Ailment Susceptibility reverted! |
| 42 | jyokyohelp_CONFUSE_RECOV | [var 0] has recovered! |
| 43 | jyokyohelp_CONFUSE_RECOV_2 | [var 0] has recovered! |
| 44 | jyokyohelp_KYOUHU_RECOVE | [var 0] has recovered! |
| 45 | jyokyohelp_KYOUHU_RECOVE_2 | [var 0] has recovered! |
| 46 | jyokyohelp_GEKIKOU_RECOV | [var 0] has recovered! |
| 47 | jyokyohelp_GEKIKOU_RECOV_2 | [var 0] has recovered! |
| 48 | jyokyohelp_SUIJYAKU_RECO | [var 0] has recovered! |
| 49 | jyokyohelp_SUIJYAKU_RECO_2 | [var 0] has recovered! |
| 50 | jyokyohelp_ROUKA_RECOVER | [var 0] has recovered! |
| 51 | jyokyohelp_ROUKA_RECOVER_2 | [var 0] has recovered! |
| 52 | jyokyohelp_CLOSE_RECOVER | [var 0] has recovered! |
| 53 | jyokyohelp_CLOSE_RECOVER_2 | [var 0] has recovered! |
| 54 | jyokyohelp_POISON_RECOVE | [var 0] is no longer poisoned! |
| 55 | jyokyohelp_POISON_RECOVE_2 | [var 0] is no longer poisoned! |
| 56 | jyokyohelp_HP_PLAYER | Insufficient HP! |
| 57 | jyokyohelp_HP_ENEMY | Insufficient HP! |
| 58 | jyokyohelp_SP_PLAYER | Insufficient SP! |
| 59 | jyokyohelp_SP_ENEMY | Insufficient SP! |
| 60 | jyokyohelp_PANIC_ERROR_P | Power is sealed! |
| 61 | jyokyohelp_PANIC_ERROR_E | Power is sealed! |
| 62 | jyokyohelp_KUISIB_PLAYER | [var 0] withstood the attack! |
| 63 | jyokyohelp_KUISIB_ENEMY | [var 0] withstood the attack! |
| 64 | jyokyohelp_FUKUTU_PLAYER | [var 0] survived! HP restored! |
| 65 | jyokyohelp_FUKUTU_ENEMY | [var 0] survived! HP restored! |
| 66 | jyokyohelp_BATK_MATK_SET | Attack up! |
| 67 | jyokyohelp_BATK_MATK_SET_2 | Attack up! |
| 68 | jyokyohelp_HIT_ESC_SET_P | Hit/Evasion rate up! |
| 69 | jyokyohelp_HIT_ESC_SET_E | Hit/Evasion rate up! |
| 70 | jyokyohelp_DEF_SET_PLAYE | Defense up! |
| 71 | jyokyohelp_DEF_SET_ENEMY | Defense up! |
| 72 | jyokyohelp_ENG_SET_PLAYE | Attack, Defense, Hit/Evasion Rate up! |
| 73 | jyokyohelp_ENG_SET_ENEMY | Attack, Defense, Hit/Evasion Rate up! |
| 74 | jyokyohelp_RND_SET_PLAYE | Attack, Defense, Hit/Evasion Rate down! |
| 75 | jyokyohelp_RND_SET_ENEMY | Attack, Defense, Hit/Evasion Rate down! |
| 76 | jyokyohelp_HIRISK_SET_PL | Critical Rate up! |
| 77 | jyokyohelp_HIRISK_SET_EN | Critical Rate up! |
| 78 | jyokyohelp_RISKHG_SET_PL | Critical Rate way up! |
| 79 | jyokyohelp_RISKHG_SET_EN | Critical Rate way up! |
| 80 | jyokyohelp_BADx2_SET_PLA | Ailment Susceptibility up! |
| 81 | jyokyohelp_BADx2_SET_ENE | Ailment Susceptibility up! |
| 82 | jyokyohelp_AGINDA_RESET_ | Fire affinity reverted! |
| 83 | jyokyohelp_AGINDA_RESET__2 | Fire affinity reverted! |
| 84 | jyokyohelp_BUFNDA_RESET_ | Ice affinity reverted! |
| 85 | jyokyohelp_BUFNDA_RESET__2 | Ice affinity reverted! |
| 86 | jyokyohelp_GALNDA_RESET_ | Wind affinity reverted! |
| 87 | jyokyohelp_GALNDA_RESET__2 | Wind affinity reverted! |
| 88 | jyokyohelp_JIONDA_RESET_ | Electricity affinity reverted! |
| 89 | jyokyohelp_JIONDA_RESET__2 | Electricity affinity reverted! |
| 90 | jyokyohelp_JAKUTAI_IMPOS | No effect! |
| 91 | jyokyohelp_JAKUTAI_IMPOS_2 | No effect! |
| 92 | jyokyohelp_BATK_MATK_DOW | Attack down! |
| 93 | jyokyohelp_BATK_MATK_DOW_2 | Attack down! |
| 94 | jyokyohelp_HIT_ESC_DOWN_ | Hit/Evasion Rate down! |
| 95 | jyokyohelp_HIT_ESC_DOWN__2 | Hit/Evasion Rate down! |
| 96 | jyokyohelp_DEF_DOWN_SET_ | Defense down! |
| 97 | jyokyohelp_DEF_DOWN_SET__2 | Defense down! |
| 98 | jyokyohelp_DEKAJA_PLAYER | All stat increases nullified! |
| 99 | jyokyohelp_DEKAJA_ENEMY | All stat increases nullified! |
| 100 | jyokyohelp_DEKUNDA_PLAYE | All stat decreases nullified! |
| 101 | jyokyohelp_DEKUNDA_ENEMY | All stat decreases nullified! |
| 102 | jyokyohelp_POWERCHARGE_P | [var 0] has charged up! |
| 103 | jyokyohelp_POWERCHARGE_E | [var 0] has charged up! |
| 104 | jyokyohelp_MINDCHARGE_PL | [var 0] is focused now! |
| 105 | jyokyohelp_MINDCHARGE_EN | [var 0] is focused now! |
| 106 | jyokyohelp_DOWN_HIROU_PL | [var 0] is dizzy! |
| 107 | jyokyohelp_DOWN_HIROU_EN | [var 0] is dizzy! |
| 108 | jyokyohelp_K_AGINDA2_PLA | Fire resistance nullified! |
| 109 | jyokyohelp_K_AGINDA2_ENE | Fire resistance nullified!! |
| 110 | jyokyohelp_K_BUFUNDA2_PL | Ice resistance nullified! |
| 111 | jyokyohelp_K_BUFUNDA2_EN | Ice resistance nullified! |
| 112 | jyokyohelp_K_JIONDA2_PLA | Elec resistance nullified! |
| 113 | jyokyohelp_K_JIONDA2_ENE | Elec resistance nullified! |
| 114 | jyokyohelp_K_GARUNDA2_PL | Wind resistance nullified! |
| 115 | jyokyohelp_K_GARUNDA2_EN | Wind resistance nullified! |
| 116 | jyokyohelp_OKANE_PLAYER | Threw  yen away! |
| 117 | jyokyohelp_OKANE_ENEMY | Threw  yen away! |
| 118 | jyokyohelp_TETORABLAKE_P | Tetrakarn is nullified! |
| 119 | jyokyohelp_TETORABLAKE_E | Tetrakarn is nullified! |
| 120 | jyokyohelp_MAKARABLAKE_P | Makarakarn is nullified! |
| 121 | jyokyohelp_MAKARABLAKE_E | Makarakarn is nullified! |
| 122 | jyokyohelp_TETORAJA_PLAY | Tetoraja is activated! |
| 123 | jyokyohelp_TETORAJA_ENEM | Tetoraja is activated! |
| 124 | jyokyohelp_REDWALL_PLAYE | Fire resistance increased! |
| 125 | jyokyohelp_REDWALL_ENEMY | Fire resistance increased! |
| 126 | jyokyohelp_WHITEWALL_PLA | Ice resistance increased! |
| 127 | jyokyohelp_WHITEWALL_ENE | Ice resistance increased! |
| 128 | jyokyohelp_BLUEWALL_PLAY | Elec resistance increased! |
| 129 | jyokyohelp_BLUEWALL_ENEM | Elec resistance increased! |
| 130 | jyokyohelp_GREENWALL_PLA | Wind resistance increased! |
| 131 | jyokyohelp_GREENWALL_ENE | Wind resistance increased! |
| 132 | jyokyohelp_REDWALL_F_PLA | Fire resistance reverted... |
| 133 | jyokyohelp_REDWALL_F_ENE | Fire resistance reverted... |
| 134 | jyokyohelp_WHITEWALL_F_P | Ice resistance reverted... |
| 135 | jyokyohelp_WHITEWALL_F_E | Ice resistance reverted... |
| 136 | jyokyohelp_BLUEWALL_F_PL | Electricity resistance reverted... |
| 137 | jyokyohelp_BLUEWALL_F_EN | Electricity resistance reverted... |
| 138 | jyokyohelp_GREENWALL_F_P | Wind resistance reverted... |
| 139 | jyokyohelp_GREENWALL_F_E | Wind resistance reverted... |
| 140 | jyokyohelp_TARGETNON | No target available. |
| 141 | jyokyohelp_ALREADY | Already in effect. |
| 142 | jyokyohelp_EXCESS | Limit reached. |
| 143 | jyokyohelp_UNNECESSARY | Not necessary. |
| 144 | jyokyohelp_DONTUSE | Can't be used right now! |
| 145 | jyokyohelp_SKILL_NONE | No skills for use in battle! |
| 146 | jyokyohelp_CLOSE_IMPOSSI | Cannot use skills! |
| 147 | jyokyohelp_CLOSE_NOTCHAN | Power is sealed! |
| 148 | jyokyohelp_GOODS_NONE | No items for use in battle! |
| 149 | jyokyohelp_OPERATION_IMP | No one to give orders to! |
| 150 | jyokyohelp_PERSONA_NONE | You don't have any other Personas! |
| 151 | jyokyohelp_PERSONA_ALREA | You've already changed Personas! |
| 152 | jyokyohelp_ESCAPE_IMPOSS | You can't escape! |
| 153 | jyokyohelp_ESCAPE_FAILUR | You failed to escape! |
| 154 | jyokyohelp_NOEFFECT | No effect! |
| 155 | jyokyohelp_TAIKI_MAYA | [var 0] seems bewildered. |
| 156 | jyokyohelp_TAIKI_RARE | [var 0] is waiting restlessly. |
| 157 | jyokyohelp_HOMUNCULUS | The Homunculus sacrificed itself! |
| 158 | jyokyohelp_TAIKI_HANYOU | [var 0] is being cautious. |
| 159 | jyokyohelp_ELIZABETH | [var 0] is looking your way. |
| 160 | jyokyohelp_erebos | [var 0] can't move. |
| 161 | jyokyohelp_SUMMON_TEKI | [var 0] appeared! |
| 162 | jyokyohelp_GKbaby | [var 0] is indignant... |
| 163 | jyokyohelp_GKokina | [var 0] is bewildered... |
| 164 | jyokyohelp_CHIE_YOUSUKE | [var 0] looks scornfully at Yosuke... |
| 165 | jyokyohelp_YUKIKO_FAIL | The Prince will no longer appear... |
| 166 | jyokyohelp_OUJI_JIBAKU | [var 0] watches intently... |
| 167 | jyokyohelp_RISE_ANALZE | [var 0] 's abilities are fully analyzed! |
| 168 | jyokyohelp_KUMA_CHARGE | Energy is concentrated to ! |
| 169 | jyokyohelp_KUMA_CHARGE_W | [var 0] is charging up! |
| 170 | jyokyohelp_NAOTO_ZERO | Elemental resistance is nullified... |
| 171 | jyokyohelp_NAOTO_ZERO_KA | Elemental resistance reverted! |
| 172 | jyokyohelp_NAMATAME_AYAT | [var 0] has been manipulated! |
| 173 | jyokyohelp_NAMATAME_AYAT_2 | [var 0] is hesitating... |
| 174 | jyokyohelp_NAMATAME_AYAT_3 | has broke free! |
| 175 | jyokyohelp_NAMATAME_AYAT_4 | Everyone broke free! |
| 176 | jyokyohelp_NAMATAME_CONV | The atmosphere changed... |
| 177 | jyokyohelp_NAMATAME_CONV_2 | The atmosphere reverted! |
| 178 | jyokyohelp_MIST_ON | Released the Fog of Confusion! |
| 179 | jyokyohelp_MIST_OFF | The fog has cleared! |
| 180 | jyokyohelp_ALL_MISS | Attacks won't connect! |
| 181 | jyokyohelp_MITUO_LVUP | Mitsuo leveled up! |
| 182 | jyokyohelp_OOKAMI | [var 0] withstood the attack! |
| 183 | jyokyohelp_YUME_KIRI | The surroundings are covered in fog... |
| 184 | jyokyohelp_IZANAMI_UNDEA | Izanami seems impervious... |
| 185 | jyokyohelp_IZANAMI_IKUSE | The Curse of Death lures ... |
| 186 | jyokyohelp_YOSUKE_SMILE | [var 0] is laughing maniacally... |
| 187 | jyokyohelp_RISE_SACRIFIC | Rise blocked all attacks! |
| 188 | jyokyohelp_ROUKA_FORGET | You forgot what you were about to do... |
| 189 | jyokyohelp_MRCRY__DEKUND | A scream nullifies all stat decreases! |
| 190 | jyokyohelp_INFINI_RESET_ | Invincibility reverted! |
| 191 | jyokyohelp_INFINI_SET_PL | Your allies are now invincible! |
| 192 | jyokyohelp_FIN_YOUSUKE_S | Hit/Evasion rate up! HP recovered! |
| 193 | jyokyohelp_FIN_KUMA001_S | All allies recovered full HP and SP! |
| 194 | jyokyohelp_FIN_KUMA002_S | All enemies are down! |
| 195 | jyokyohelp_FIN_KUMA003_S | All enemies receive a status ailment! |
| 196 | jyokyohelp_FIN_KUMA004_S | All combatants' HP and SP fully recovered! |
| 197 | jyokyohelp_FIN_KUMA005_S | All combatants Down! |
| 198 | jyokyohelp_FIN_KUMA006_S | All combatants get a status ailment! |
| 199 | jyokyohelp_FIN_KUMA007_S | All enemies' HP and SP fully recovered! |
| 200 | jyokyohelp_FIN_KUMA008_S | All allies down! |
| 201 | jyokyohelp_FIN_KUMA009_S | Nothing happened! |
| 202 | jyokyohelp_YUKIKO_WAIT | Shadow Yukiko has a passionate stare... |
| 203 | jyokyohelp_NET_CHEER_SET | Everyone's encouragement empowers you! |
| 204 | jyokyohelp_MIST__NOMIST | Marie's body is breaking... |
| 205 | jyokyohelp_MARRY01_TXT01 | Marie's eyes are sad... |
| 206 | jyokyohelp_MARRY01_TXT02 | Marie looks bewildered... |
| 207 | jyokyohelp_MARRY01_TXT03 | Marie's will to fight is ebbing... |
| 208 | jyokyohelp_MARRY02_TXT01 | Marie's ego is struggling for control! |
| 209 | jyokyohelp_MARRY02_TXT02 | Marie's remaining ego is struggling... |
| 210 | jyokyohelp_MARRY02_TXT03 | The fog within Marie is out of control... |
| 211 | jyokyohelp_BATK_MATK_ADD | Attack increase lasts longer! |
| 212 | jyokyohelp_HIT_ESC_ADD_P | Hit/Evasion rate increase lasts longer! |
| 213 | jyokyohelp_DEF_ADD_PLAYE | Defense increase lasts longer! |
| 214 | jyokyohelp_ENG_ADD_PLAYE | All stat increases last longer! |
| 215 | jyokyohelp_BATK_MATK_DOW_3 | Attack decrease lasts longer! |
| 216 | jyokyohelp_HIT_ESC_DOWN__3 | Hit/Evasion rate decrease lasts longer! |
| 217 | jyokyohelp_DEF_DOWN_ADD_ | Defense decrease lasts longer! |
| 218 | jyokyohelp_RND_ADD_PLAYE | All stat decreases last longer! |
| 219 | jyokyohelp_BATK_MATK_SET_3 | All allies' attack increased! |
| 220 | jyokyohelp_HIT_ESC_SET_A | All allies' hit/evasion rate increased! |
| 221 | jyokyohelp_DEF_SET_ASSIS | All allies' defense increased! |
| 222 | jyokyohelp_W_CHARGE_SET_ | All allies are charged up and focused! |
| 223 | jyokyohelp_HP_HEAL_SET_A | All allies recovered HP! |
| 224 | jyokyohelp_SP_HEAL_SET_A | All allies recovered SP! |
| 225 | jyokyohelp_HOMUNCULUSNAS | Scapegoat Eggplant took the hit! |
| 226 | jyokyohelp_TAIKI_YOTYOU | [var 0] is gathering magic power... |
| 227 | jyokyohelp_BADRCV_SET_AS | Ally status ailments recovered! |
| 228 | jyokyohelp_DEADRCV_SET_A | Ally KO recovered! |
| 229 | jyokyohelp_ANIKI_A_WAIT | Nice Guy gives a toothy smile... |
| 230 | jyokyohelp_ANIKI_B_WAIT | Tough Guy is posing... |
| 231 | jyokyohelp_TETRKN | A Phys wall has been erected! |
| 232 | jyokyohelp_MAKRKN | A Magic wall has been erected! |
| 233 | jyokyohelp_TTRJYA | An instant death wall has been erected! |
| 234 | jyokyohelp_SEIGINOTATE | An attack wall has been erected! |
| 235 | jyokyohelp_REDWALL_ADD_P | Fire resistance lasts longer! |
| 236 | jyokyohelp_WHITEWALL_ADD | Ice resistance lasts longer! |
| 237 | jyokyohelp_BLUEWALL_ADD_ | Elec resistance lasts longer! |
| 238 | jyokyohelp_GREENWALL_ADD | Wind resistance lasts longer! |
| 239 | jyokyohelp_K_AGINDA2_ADD | Fire break lasts longer! |
| 240 | jyokyohelp_K_BUFUNDA2_AD | Ice break lasts longer! |
| 241 | jyokyohelp_K_JIONDA2_ADD | Elec break lasts longer! |
| 242 | jyokyohelp_K_GARUNDA2_AD | Wind break lasts longer! |
| 243 | jyokyohelp_K_ALL_PLAYER | All resistances have been nullified! |
| 244 | jyokyohelp_K_ALL_ADD_PLA | Resistance nullification lasts longer! |
