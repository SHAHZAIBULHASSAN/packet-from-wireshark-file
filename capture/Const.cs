﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPRECLoadTestCallGeneratorTool.Helpers
{
    public class Const
    {
        public const ushort ARPHRD_ARCNET = 7;
        public const ushort ARPHRD_ATM = 16;
        public const ushort ARPHRD_ATM2 = 21;
        public const ushort ARPHRD_ATM2225 = 19;
        public const ushort ARPHRD_AUTONET = 10;
        public const ushort ARPHRD_AX25 = 3;
        public const ushort ARPHRD_CHAOS = 5;
        public const ushort ARPHRD_DLCI = 15;
        public const ushort ARPHRD_EETHER = 2;
        public const ushort ARPHRD_ETHER = 1;
        public const ushort ARPHRD_EUI_64 = 27;
        public const ushort ARPHRD_FIBREC = 18;
        public const ushort ARPHRD_HDLC = 17;
        public const ushort ARPHRD_HYPERCH = 8;
        public const ushort ARPHRD_IEEE1394 = 24;
        public const ushort ARPHRD_IEEE802 = 6;
        public const ushort ARPHRD_LANSTAR = 9;
        public const ushort ARPHRD_LOCALNET = 12;
        public const ushort ARPHRD_LOCALTLK = 11;
        public const ushort ARPHRD_MAPOS = 25;
        public const ushort ARPHRD_METRICOM = 23;
        public const ushort ARPHRD_MS188220 = 22;
        public const ushort ARPHRD_NETROM = 0;
        public const ushort ARPHRD_PRONET = 4;
        public const ushort ARPHRD_SERIAL = 20;
        public const ushort ARPHRD_SMDS = 14;
        public const ushort ARPHRD_TWINAX = 26;
        public const ushort ARPHRD_ULTRALNK = 13;
        public const ushort ARPOP_IREPLY = 9;
        public const ushort ARPOP_IREQUEST = 8;
        public const ushort ARPOP_REPLY = 2;
        public const ushort ARPOP_REQUEST = 1;
        public const ushort ARPOP_RREPLY = 4;
        public const ushort ARPOP_RREQUEST = 3;
        public const ushort ATMARPOP_NAK = 10;
        public const ushort CLASS_ANY = 255;
        public const ushort CLASS_CHAOS = 3;
        public const ushort CLASS_CSNET = 2;
        public const ushort CLASS_FLUSH = 32768;
        public const ushort CLASS_HESIOD = 4;
        public const ushort CLASS_INET = 1;
        public const ushort CLASS_NONE = 254;
        public const byte DSAP_GI_BIT = 1;
        public const ushort ETHERTYPE_8021Q = 33024;
        public const string ETHERTYPE_8021Q_STR = "8021Q ";
        public const ushort ETHERTYPE_AARP = 33011;
        public const string ETHERTYPE_AARP_STR = "AARP ";
        public const ushort ETHERTYPE_ARP = 2054;
        public const string ETHERTYPE_ARP_STR = "ARP ( Address Resolution Protocol )";
        public const ushort ETHERTYPE_ATALK = 32923;
        public const string ETHERTYPE_ATALK_STR = "ATALK ( Apple Talk )";
        public const ushort ETHERTYPE_DECDNS = 32828;
        public const string ETHERTYPE_DECDNS_STR = "DEC DNS ";
        public const ushort ETHERTYPE_DECDTS = 32830;
        public const string ETHERTYPE_DECDTS_STR = "DEC TS ";
        public const ushort ETHERTYPE_DN = 24579;
        public const string ETHERTYPE_DN_STR = "DN ";
        public const ushort ETHERTYPE_IP = 2048;
        public const string ETHERTYPE_IP_STR = "IP ( Internet Protocol )";
        public const ushort ETHERTYPE_IPV6 = 34525;
        public const string ETHERTYPE_IPV6_STR = "IPV6 ";
        public const ushort ETHERTYPE_IPX = 33079;
        public const string ETHERTYPE_IPX_STR = "IPX ( Internet Packet Excahge )";
        public const ushort ETHERTYPE_LANBRIDGE = 32824;
        public const string ETHERTYPE_LANBRIDGE_STR = "LAN BRIDGE ";
        public const ushort ETHERTYPE_LAT = 24580;
        public const string ETHERTYPE_LAT_STR = "LAT ";
        public const ushort ETHERTYPE_LOOPBACK = 36864;
        public const string ETHERTYPE_LOOPBACK_STR = "LOOPBACK ";
        public const ushort ETHERTYPE_MOPDL = 24577;
        public const string ETHERTYPE_MOPDL_STR = "MOPDL ";
        public const ushort ETHERTYPE_MOPRC = 24578;
        public const string ETHERTYPE_MOPRC_STR = "MOPRC ";
        public const ushort ETHERTYPE_NS = 1536;
        public const string ETHERTYPE_NS_STR = "NS ";
        public const ushort ETHERTYPE_PUP = 512;
        public const string ETHERTYPE_PUP_STR = "PUP";
        public const ushort ETHERTYPE_REVARP = 32821;
        public const string ETHERTYPE_REVARP_STR = "RARP ( Reverse Address Resolution Protocol )";
        public const ushort ETHERTYPE_SCA = 24583;
        public const string ETHERTYPE_SCA_STR = "SCA ";
        public const ushort ETHERTYPE_SPRITE = 1280;
        public const string ETHERTYPE_SPRITE_STR = "SPRITE ";
        public const ushort ETHERTYPE_TRAIL = 4096;
        public const string ETHERTYPE_TRAIL_STR = "TRAIL ";
        public const ushort ETHERTYPE_VEXP = 32859;
        public const string ETHERTYPE_VEXP_STR = "VEXP ";
        public const ushort ETHERTYPE_VPROD = 32860;
        public const string ETHERTYPE_VPROD_STR = "VPROD ";
        public const int F_OPCODE = 30720;
        public const ushort FLAGS_AUTHORITATIVE = 1024;
        public const ushort FLAGS_BROADCAST = 16;
        public const byte FLAGS_CANONICALIZED_PATH_NAMES = 16;
        public const byte FLAGS_CASE_SENSITIVITY = 8;
        public const byte FLAGS_LOCK_AND_READ = 1;
        public const byte FLAGS_NOTIFY = 64;
        public const ushort FLAGS_OP_CODE = 30720;
        public const byte FLAGS_OPLOCKS = 32;
        public const byte FLAGS_RECEIVE_BUFFER_POSTED = 2;
        public const ushort FLAGS_RECURSION_AVAILABLE = 128;
        public const ushort FLAGS_RECURSION_DESIRED = 256;
        public const ushort FLAGS_REPLY_CODE = 15;
        public const byte FLAGS_REQUEST_RESPONSE = 128;
        public const ushort FLAGS_RESPONSE = 32768;
        public const ushort FLAGS_TRUNCATED = 512;
        public const ushort FLAGS2_DFS = 4096;
        public const ushort FLAGS2_ERROR_CODE_TYPE = 16384;
        public const ushort FLAGS2_EXECUTE_ONLY_READS = 8192;
        public const ushort FLAGS2_EXTENDED_ATTRIBUTES = 2;
        public const ushort FLAGS2_EXTENDED_SECURITY_NEGOTIATION = 2048;
        public const ushort FLAGS2_LONG_NAMES_ALLOWED = 1;
        public const ushort FLAGS2_LONG_NAMES_USED = 64;
        public const ushort FLAGS2_SECUTIRY_SIGNATURES = 4;
        public const ushort FLAGS2_UNICODE_STRINGS = 32768;
        public const byte FORMAT_TYPE_ASCII = 4;
        public const byte FORMAT_TYPE_DATA_BLOCK = 1;
        public const int IPPORT_ACCT = 702;
        public const int IPPORT_ACCTDISK = 707;
        public const int IPPORT_ACCTINFO = 705;
        public const int IPPORT_ACCTLOGIN = 703;
        public const int IPPORT_ACCTMASTER = 700;
        public const int IPPORT_ACCTPRINTER = 704;
        public const int IPPORT_ACCTSLAVE = 701;
        public const int IPPORT_ACCTSLAVE2 = 706;
        public const int IPPORT_AUTH = 113;
        public const int IPPORT_BIFF = 512;
        public const int IPPORT_BOOTP = 67;
        public const int IPPORT_BUSBOY = 602;
        public const int IPPORT_CHARGEN = 19;
        public const int IPPORT_CMDSERVER = 514;
        public const int IPPORT_CONFERENCE = 531;
        public const int IPPORT_COURIER = 530;
        public const int IPPORT_CSNET_NS = 105;
        public const int IPPORT_DAYTIME = 13;
        public const int IPPORT_DICTIONARY = 103;
        public const int IPPORT_DISCARD = 9;
        public const int IPPORT_DLSW_TCP = 2065;
        public const int IPPORT_DLSW_UDP = 2067;
        public const int IPPORT_DNS = 43;
        public const int IPPORT_DOMAIN = 53;
        public const int IPPORT_ECHO = 7;
        public const int IPPORT_EFS = 520;
        public const int IPPORT_EPMEP = 135;
        public const int IPPORT_ERRLOGIN = 888;
        public const int IPPORT_EXEC = 512;
        public const int IPPORT_EXECSERVER = 512;
        public const int IPPORT_FINGER = 79;
        public const int IPPORT_FTP = 21;
        public const int IPPORT_FTP_DATA = 20;
        public const int IPPORT_GARCON = 600;
        public const int IPPORT_HOSTNAMES = 101;
        public const int IPPORT_HTTP = 80;
        public const int IPPORT_HTTP2 = 8080;
        public const int IPPORT_HTTPS = 443;
        public const int IPPORT_ISP_TSAP = 102;
        public const int IPPORT_KERBEROS = 750;
        public const int IPPORT_KERBEROS_MASTER = 751;
        public const int IPPORT_KLOGIN = 543;
        public const int IPPORT_KRB_PROP = 754;
        public const int IPPORT_KSHEL = 544;
        public const int IPPORT_LINK = 87;
        public const int IPPORT_LOAD = 315;
        public const int IPPORT_LOGIN = 513;
        public const int IPPORT_LOGINSERVER = 513;
        public const int IPPORT_MAITRD = 601;
        public const int IPPORT_MONITOR = 561;
        public const int IPPORT_MTP = 57;
        public const int IPPORT_NAME = 42;
        public const int IPPORT_NAMESERVER = 42;
        public const int IPPORT_NB_DATAGRAM = 138;
        public const int IPPORT_NB_NAME = 137;
        public const int IPPORT_NB_SESSION = 139;
        public const int IPPORT_NBDTGRM = 138;
        public const int IPPORT_NBNS = 137;
        public const int IPPORT_NBSSN = 139;
        public const int IPPORT_NETBIOS_DATAGRAM = 138;
        public const int IPPORT_NETBIOS_NS = 137;
        public const int IPPORT_NETBIOS_SSN = 139;
        public const int IPPORT_NETNEWS = 532;
        public const int IPPORT_NETSTAT = 15;
        public const int IPPORT_NETWALL = 533;
        public const int IPPORT_NEW_RWHO = 550;
        public const int IPPORT_NEWS = 144;
        public const int IPPORT_NNTP = 119;
        public const int IPPORT_NTALK = 518;
        public const int IPPORT_NTP = 123;
        public const int IPPORT_PASSWD_SERVER = 752;
        public const int IPPORT_PATH = 117;
        public const int IPPORT_POP = 109;
        public const int IPPORT_POP3 = 110;
        public const int IPPORT_PORTMAP = 111;
        public const int IPPORT_PRINT_SRV = 170;
        public const int IPPORT_PRINTER = 515;
        public const int IPPORT_QOTD = 17;
        public const int IPPORT_REMOTEFS = 556;
        public const int IPPORT_RJE = 77;
        public const int IPPORT_RLP = 39;
        public const int IPPORT_RMONITOR = 560;
        public const int IPPORT_ROUTE = 520;
        public const int IPPORT_ROUTESERVER = 520;
        public const int IPPORT_RVD_CONTROL = 531;
        public const int IPPORT_SFTP = 115;
        public const int IPPORT_SGMP = 153;
        public const int IPPORT_SHEL = 514;
        public const int IPPORT_SKINNY = 2000;
        public const int IPPORT_SMTP = 25;
        public const int IPPORT_SNMP = 161;
        public const int IPPORT_SNMP_TRAP = 162;
        public const int IPPORT_SSDP = 1031;
        public const int IPPORT_SSDP2 = 1032;
        public const int IPPORT_SUPDUP = 95;
        public const int IPPORT_SYSLOG = 514;
        public const int IPPORT_SYSTAT = 11;
        public const int IPPORT_SYTEK = 500;
        public const int IPPORT_TALK = 517;
        public const int IPPORT_TCPREPO = 158;
        public const int IPPORT_TELNET = 23;
        public const int IPPORT_TEMPO = 526;
        public const int IPPORT_TFTP = 69;
        public const int IPPORT_TIME = 37;
        public const int IPPORT_TIMED = 525;
        public const int IPPORT_TIMESERVER = 37;
        public const int IPPORT_TTYLINK = 87;
        public const int IPPORT_USERREG_SERVER = 753;
        public const int IPPORT_UUCP = 540;
        public const int IPPORT_VMNET = 175;
        public const int IPPORT_VMNET0 = 400;
        public const int IPPORT_WHO = 513;
        public const int IPPORT_WHOIS = 43;
        public const int IPPORT_WHOSERVER = 513;
        public const int IPPORT_X400_SND = 104;
        public const int IPPROTO_ICMP = 1;
        public const int IPPROTO_IP = 0;
        public const int IPPROTO_IPV6 = 41;
        public const int IPPROTO_MAX = 256;
        public const int IPPROTO_RAW = 255;
        public const int IPPROTO_TCP = 6;
        public const int IPPROTO_UDP = 17;
        public const int LENGTH_OF_ARP = 28;
        public const int LENGTH_OF_ETHERNET = 14;
        public const int LENGTH_OF_ICMP = 8;
        public const int LENGTH_OF_INTERNET = 20;
        public const int LENGTH_OF_TCP = 20;
        public const int LENGTH_OF_UDP = 8;
        public const byte LLC_TYPE_ARPANET_ARP = 152;
        public const byte LLC_TYPE_ARPANET_IP = 6;
        public const byte LLC_TYPE_BANYAN_VINES = 188;
        public const byte LLC_TYPE_EIA_MMS = 78;
        public const byte LLC_TYPE_GLOBAL_LSAP = 255;
        public const byte LLC_TYPE_IBM_LANMAN_G = 245;
        public const byte LLC_TYPE_IBM_LANMAN_I = 244;
        public const byte LLC_TYPE_IBM_NETBIOS = 240;
        public const byte LLC_TYPE_IBM_RPL = 248;
        public const byte LLC_TYPE_IBM_SNA_PATH_CTRL_G = 5;
        public const byte LLC_TYPE_IBM_SNA_PATH_CTRL_I = 4;
        public const byte LLC_TYPE_ISO_NLP = 254;
        public const byte LLC_TYPE_LSAP = 0;
        public const byte LLC_TYPE_NESTAR = 134;
        public const byte LLC_TYPE_NOVELL_NETWARE = 224;
        public const byte LLC_TYPE_PROWAY = 142;
        public const byte LLC_TYPE_SMAN_FUNCTION_G = 3;
        public const byte LLC_TYPE_SMAN_FUNCTION_I = 2;
        public const byte LLC_TYPE_SNA_CSNA_EPROWAY = 8;
        public const byte LLC_TYPE_SNAP = 170;
        public const byte LLC_TYPE_STP = 66;
        public const byte LLC_TYPE_TEXAS_INSTRUMENTS = 24;
        public const byte LLC_TYPE_UNGERMANN_BASS = 250;
        public const byte LLC_TYPE_X25_OVER_LLC2 = 126;
        public const byte LLC_TYPE_XNS = 128;
        public const byte LLCSAP_8021B_G = 3;
        public const byte LLCSAP_8021B_I = 2;
        public const byte LLCSAP_8021D = 66;
        public const byte LLCSAP_GLOBAL = 255;
        public const byte LLCSAP_IP = 6;
        public const byte LLCSAP_IPX = 224;
        public const byte LLCSAP_ISO8208 = 126;
        public const byte LLCSAP_ISONS = 254;
        public const byte LLCSAP_NETBEUI = 240;
        public const byte LLCSAP_NULL = 0;
        public const byte LLCSAP_PROWAY = 142;
        public const byte LLCSAP_PROWAYNM = 14;
        public const byte LLCSAP_RS511 = 78;
        public const byte LLCSAP_SNAP = 170;
        public const int MONO = 1;
        public const ushort NAME_FLAGS_ACT = 1024;
        public const ushort NAME_FLAGS_B_NODE = 0;
        public const ushort NAME_FLAGS_CNF = 2048;
        public const ushort NAME_FLAGS_DRG = 4096;
        public const ushort NAME_FLAGS_G = 32768;
        public const ushort NAME_FLAGS_M_NODE = 2;
        public const ushort NAME_FLAGS_MASK = 24576;
        public const ushort NAME_FLAGS_P_NODE = 1;
        public const ushort NAME_FLAGS_PRM = 512;
        public const byte NB_ADD_GROUP = 0;
        public const byte NB_ADD_NAME = 1;
        public const byte NB_ADD_NAME_RESP = 13;
        public const byte NB_DATA_ACK = 20;
        public const byte NB_DATA_FIRST_MIDDLE = 21;
        public const byte NB_DATA_ONLY_LAST = 22;
        public const byte NB_DATAGRAM = 8;
        public const byte NB_DATAGRAM_BCAST = 9;
        public const ushort NB_FLAGS_B_NODE = 0;
        public const ushort NB_FLAGS_G = 32768;
        public const ushort NB_FLAGS_H_NODE = 3;
        public const ushort NB_FLAGS_M_NODE = 2;
        public const ushort NB_FLAGS_MASK = 24576;
        public const ushort NB_FLAGS_P_NODE = 1;
        public const byte NB_KEEP_ALIVE = 31;
        public const byte NB_NAME_IN_CONFLICT = 2;
        public const byte NB_NAME_QUERY = 10;
        public const byte NB_NAME_RESP = 14;
        public const byte NB_NO_RECEIVE = 26;
        public const byte NB_RECEIVE_CONTINUE = 28;
        public const byte NB_RECEIVE_OUTSTANDING = 27;
        public const byte NB_SESSION_CONFIRM = 23;
        public const byte NB_SESSION_END = 24;
        public const byte NB_SESSION_INIT = 25;
        public const byte NB_STATUS_QUERY = 3;
        public const byte NB_STATUS_RESP = 15;
        public const byte NB_TERMINATE_TRACE_LR = 19;
        public const byte NB_TERMINATE_TRACE_R = 7;
        public const byte NBDS_BROADCAST = 18;
        public const byte NBDS_DIRECT_GROUP = 17;
        public const byte NBDS_DIRECT_UNIQUE = 16;
        public const byte NBDS_ERROR = 19;
        public const byte NBDS_NEG_QUERY_RESPONSE = 22;
        public const byte NBDS_POS_QUERY_RESPONSE = 21;
        public const byte NBDS_QUERY_REQUEST = 20;
        public const byte NBSS_FLAGS_E = 1;
        public const byte NEGATIVE_SESSION_RESPONSE = 131;
        public const byte NLPID_COMPRESSED = 176;
        public const byte NLPID_IP = 204;
        public const byte NLPID_IP6 = 142;
        public const byte NLPID_IPI_T_70 = 1;
        public const byte NLPID_ISO10030 = 140;
        public const byte NLPID_ISO10589_ISIS = 131;
        public const byte NLPID_ISO10747_IDRP = 133;
        public const byte NLPID_ISO11577 = 141;
        public const byte NLPID_ISO8473_CLNP = 129;
        public const byte NLPID_ISO9542_ESIS = 130;
        public const byte NLPID_ISO9542X25_ESIS = 138;
        public const byte NLPID_NULL = 0;
        public const byte NLPID_PPP = 207;
        public const byte NLPID_Q_2119 = 12;
        public const byte NLPID_Q_2931 = 9;
        public const byte NLPID_Q_931 = 8;
        public const byte NLPID_SNAP = 128;
        public const byte NLPID_SNDCF = 193;
        public const byte NLPID_SPI_X_29 = 1;
        public const byte NLPID_X_633 = 3;
        public const int NORMAL = 0;
        public const byte OPCODE_MHREGISTRATION = 15;
        public const byte OPCODE_QUERY = 0;
        public const byte OPCODE_REFRESH = 8;
        public const byte OPCODE_REFRESHALT = 9;
        public const byte OPCODE_REGISTRATION = 5;
        public const byte OPCODE_RELEASE = 6;
        public const ushort OPCODE_SHIFT = 11;
        public const byte OPCODE_WACK = 7;
        public const uint OUI_APPLE_ATALK = 524295;
        public const uint OUI_ATM_FORUM = 41022;
        public const uint OUI_BRIDGED = 32962;
        public const uint OUI_CABLE_BPDU = 57391;
        public const uint OUI_CISCO = 12;
        public const uint OUI_CISCO_90 = 248;
        public const uint OUI_ENCAP_ETHER = 0;
        public const uint PACKET_ALIGNMENT = 4;
        public const int PACKET_ORGANIZATION_CISCO = 12;
        public const byte PACKET_TYPE_NCP = 17;
        public const byte PACKET_TYPE_SPX = 5;
        public const ushort PCAP_VERSION_MAJOR = 2;
        public const ushort PCAP_VERSION_MINOR = 4;
        public const byte POSITIVE_SESSION_RESPONSE = 130;
        public const byte PROTO_TYPE_IEEE_802_2 = 2;
        public const byte PROTO_TYPE_NLPID = 1;
        public const int PROTOCOL_TYPE_ARP = 1;
        public const int PROTOCOL_TYPE_CDP = 2;
        public const int PROTOCOL_TYPE_INTERNET = 7;
        public const int PROTOCOL_TYPE_NONE = 0;
        public const int PROTOCOL_TYPE_TCP = 21;
        public const int PROTOCOL_TYPE_UDP = 22;
        public const byte RAWMODE_READ = 1;
        public const byte RAWMODE_WRITE = 2;
        public const byte RCODE_ACTIVE = 6;
        public const byte RCODE_CONFLICT = 7;
        public const byte RCODE_FMTERROR = 1;
        public const byte RCODE_NAMEERROR = 3;
        public const byte RCODE_NOERROR = 0;
        public const byte RCODE_NOTIMPL = 4;
        public const byte RCODE_REFUSED = 5;
        public const byte RCODE_SERVFAIL = 2;
        public const byte RETARGET_SESSION_RESPONSE = 132;
        public const int RIFFHEADERLENGTH = 44;
        public const byte SAP_MASK = 254;
        public const byte SECURITY_MODE_MODE = 1;
        public const byte SECURITY_MODE_PASSWORD = 2;
        public const byte SECURITY_MODE_SIG_REQUIRED = 8;
        public const byte SECURITY_MODE_SIGNATURES = 4;
        public const byte SESSION_KEEP_ALIVE = 133;
        public const byte SESSION_MESSAGE = 0;
        public const byte SESSION_REQUEST = 129;
        public const ushort SOCKET_TYPE_SAP = 1106;
        public const byte SSAP_CR_BIT = 1;
        public const int STEREO = 2;
        public const byte T_NB = 32;
        public const byte T_NBSTAT = 33;
        public const ushort TCP_PORT_CIFS = 445;
        public const ushort TCP_PORT_NBSS = 139;
        public const uint TCPDUMP_MAGIC = 2712847316;
        public const ushort TYPE_ADDRESS = 2;
        public const ushort TYPE_CAPABILITIES = 4;
        public const ushort TYPE_DEVICE_ID = 1;
        public const ushort TYPE_DUPLEX = 11;
        public const ushort TYPE_IOS_VERSION = 5;
        public const ushort TYPE_IP_PREFIX = 7;
        public const ushort TYPE_NATIVE_VLAN = 10;
        public const ushort TYPE_NB = 32;
        public const ushort TYPE_NBSTAT = 33;
        public const ushort TYPE_PLATFORM = 6;
        public const ushort TYPE_PORT_ID = 3;
        public const ushort TYPE_VTP_MGMT_DOMAIN = 9;
        public const int UDP_PORT_LLC1 = 12000;
        public const int UDP_PORT_LLC2 = 12001;
        public const int UDP_PORT_LLC3 = 12002;
        public const int UDP_PORT_LLC4 = 12003;
        public const int UDP_PORT_LLC5 = 12004;
        public const ushort UDP_PORT_NBDGM = 138;
        public const ushort UDP_PORT_NBNS = 137;
        public const int VALUE = 1;
        public const byte XDLC_BCN = 236;
        public const byte XDLC_CFGR = 196;
        public const byte XDLC_DISC = 64;
        public const byte XDLC_DM = 12;
        public const byte XDLC_FRMR = 132;
        public const byte XDLC_I = 0;
        public const ushort XDLC_N_R_EXT_MASK = 65024;
        public const ushort XDLC_N_R_EXT_SHIFT = 9;
        public const ushort XDLC_N_R_MASK = 224;
        public const ushort XDLC_N_R_SHIFT = 5;
        public const ushort XDLC_N_S_EXT_MASK = 254;
        public const ushort XDLC_N_S_EXT_SHIFT = 1;
        public const ushort XDLC_N_S_MASK = 14;
        public const ushort XDLC_N_S_SHIFT = 1;
        public const ushort XDLC_P_F = 16;
        public const ushort XDLC_P_F_EXT = 256;
        public const byte XDLC_RD = 64;
        public const ushort XDLC_REJ = 8;
        public const byte XDLC_RESET = 140;
        public const byte XDLC_RIM = 4;
        public const ushort XDLC_RNR = 4;
        public const ushort XDLC_RR = 0;
        public const byte XDLC_S = 1;
        public const ushort XDLC_S_FTYPE_MASK = 12;
        public const byte XDLC_SABM = 44;
        public const byte XDLC_SABME = 108;
        public const byte XDLC_SARM = 12;
        public const byte XDLC_SARME = 76;
        public const byte XDLC_SIM = 4;
        public const byte XDLC_SNRM = 128;
        public const byte XDLC_SNRME = 204;
        public const ushort XDLC_SREJ = 12;
        public const byte XDLC_TEST = 224;
        public const byte XDLC_U = 3;
        public const byte XDLC_U_MODIFIER_MASK = 236;
        public const byte XDLC_UA = 96;
        public const byte XDLC_UI = 0;
        public const byte XDLC_UP = 32;
        public const byte XDLC_XID = 172;
    }
}