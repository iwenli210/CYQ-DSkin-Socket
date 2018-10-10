using System;

namespace CameraMonitorProj.Model
{
    /// <summary>
    /// ������λ��
    /// </summary>
    public class Base_Organize
    {
        /// <summary>
        /// ��������
        /// </summary>
        public string OrganizeId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public int Category { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string EnCode { get; set; }
        /// <summary>
        /// �������
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string Nature { get; set; }
        /// <summary>
        /// ���ߵ绰
        /// </summary>
        public string OuterPhone { get; set; }
        /// <summary>
        /// ���ߵ绰
        /// </summary>
        public string InnerPhone { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// �ʱ�
        /// </summary>
        public string Postalcode { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string ManagerId { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public string Manager { get; set; }
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
        /// <summary>
        /// ��˾��ҳ
        /// </summary>
        public string WebAddress { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime FoundedTime { get; set; }
        /// <summary>
        /// ��Ӫ��Χ
        /// </summary>
        public string BusinessScope { get; set; }
        /// <summary>
        /// ��
        /// </summary>
        public int Layer { get; set; }
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
    }
}
