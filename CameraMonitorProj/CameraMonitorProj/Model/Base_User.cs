using System;

namespace CameraMonitorProj.Model
{
    /// <summary>
    /// �û���Ϣ��
    /// </summary>
    public class Base_User
    {
        /// <summary>
        /// �û�����
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// �û�����
        /// </summary>
        public string EnCode { get; set; }
        /// <summary>
        /// ��¼�˻�
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// ��¼����
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// ������Կ
        /// </summary>
        public string Secretkey { get; set; }
        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// �س�
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// ͷ��
        /// </summary>
        public string HeadIcon { get; set; }
        /// <summary>
        /// ���ٲ�ѯ
        /// </summary>
        public string QuickQuery { get; set; }
        /// <summary>
        /// ��ƴ
        /// </summary>
        public string SimpleSpelling { get; set; }
        /// <summary>
        /// �Ա�
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// �ֻ�
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// �绰
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// �����ʼ�
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// QQ��
        /// </summary>
        public string OICQ { get; set; }
        /// <summary>
        /// ΢�ź�
        /// </summary>
        public string WeChat { get; set; }
        /// <summary>
        /// MSN
        /// </summary>
        public string MSN { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string ManagerId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string OrganizeId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        /// ��ɫ����
        /// </summary>
        public string RoleId { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        public string DutyId { get; set; }
        /// <summary>
        /// ��λ����
        /// </summary>
        public string DutyName { get; set; }
        /// <summary>
        /// ְλ����
        /// </summary>
        public string PostId { get; set; }
        /// <summary>
        /// ְλ����
        /// </summary>
        public string PostName { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string WorkGroupId { get; set; }
        /// <summary>
        /// ��ȫ����
        /// </summary>
        public int SecurityLevel { get; set; }
        /// <summary>
        /// ����״̬
        /// </summary>
        public int UserOnLine { get; set; }
        /// <summary>
        /// �����¼��ʶ
        /// </summary>
        public int OpenId { get; set; }
        /// <summary>
        /// ������ʾ����
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// ������ʾ��
        /// </summary>
        public string AnswerQuestion { get; set; }
        /// <summary>
        /// ������û�ͬʱ��¼
        /// </summary>
        public int CheckOnLine { get; set; }
        /// <summary>
        /// �����¼ʱ�俪ʼ
        /// </summary>
        public DateTime AllowStartTime { get; set; }
        /// <summary>
        /// �����¼ʱ�����
        /// </summary>
        public DateTime AllowEndTime { get; set; }
        /// <summary>
        /// ��ͣ�û���ʼ����
        /// </summary>
        public DateTime LockStartDate { get; set; }
        /// <summary>
        /// ��ͣ�û���������
        /// </summary>
        public DateTime LockEndDate { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        public DateTime FirstVisit { get; set; }
        /// <summary>
        /// ��һ�η���ʱ��
        /// </summary>
        public DateTime PreviousVisit { get; set; }
        /// <summary>
        /// ������ʱ��
        /// </summary>
        public DateTime LastVisit { get; set; }
        /// <summary>
        /// ��¼����
        /// </summary>
        public int LogOnCount { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int SortCode { get; set; }
        /// <summary>
        /// ɾ�����
        /// </summary>
        public int DeleteMark { get; set; }
        /// <summary>
        /// ��Ч��־
        /// </summary>
        public int EnabledMark { get; set; }
        /// <summary>
        /// ��ע
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// �����û�����
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// �����û�
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// �޸�����
        /// </summary>
        public DateTime ModifyDate { get; set; }
        /// <summary>
        /// �޸��û�����
        /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// �޸��û�
        /// </summary>
        public string ModifyUserName { get; set; }
        public string WxOpenId { get; set; }
        /// <summary>
        /// ʡ����
        /// </summary>
        public string ProvinceId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// ��/������
        /// </summary>
        public string CountyId { get; set; }
        /// <summary>
        /// ��ϸ��ַ
        /// </summary>
        public string Address { get; set; }
    }
}
