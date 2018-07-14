using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Entity;
using Models.Enum;
using Models.Validation;

namespace Models.DTO
{
    /// <summary>
    /// ���۱�����ģ��
    /// </summary>
    public class CommentInputDto : BaseEntity
    {
        public CommentInputDto()
        {
            Status = Status.Pending;
            IsMaster = false;
        }
        /// <summary>
        /// �ǳ�
        /// </summary>
        [Required(ErrorMessage = "��ȻҪ���ۣ���������ô���أ�"), MaxLength(24, ErrorMessage = "���֣���������̫���˰ɣ�"), MinLength(2, ErrorMessage = "�ǳ�����2���֣�")]
        public string NickName { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [IsEmail]
        public string Email { get; set; }

        /// <summary>
        /// QQ��΢��
        /// </summary>
        public string QQorWechat { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [Required(ErrorMessage = "�������ݲ���Ϊ�գ�"), SubmitCheck(3, 500)]
        public string Content { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// ����ID
        /// </summary>
        public int PostId { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime CommentDate { get; set; }

        /// <summary>
        /// ������汾
        /// </summary>
        [StringLength(255)]
        public string Browser { get; set; }

        /// <summary>
        /// ����ϵͳ�汾
        /// </summary>
        [StringLength(255)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// �Ƿ��ǲ���
        /// </summary>
        [DefaultValue(false)]
        public bool IsMaster { get; set; }

        /// <summary>
        /// ֧����
        /// </summary>
        public int VoteCount { get; set; }

        /// <summary>
        /// ������
        /// </summary>
        public int AgainstCount { get; set; }

        /// <summary>
        /// ������IP
        /// </summary>
        public string IP { get; set; }

    }

}